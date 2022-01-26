using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace EncryptedTextMethodCreator;

public static class Utility
{
    public enum EncryptionType
    {
        Xor,
        Aes,
        Xtea
    };

    private static readonly byte[] salt = Convert.FromBase64String("OTg3NjU0MzIxMDY1NDk4Nw==");

    public static (string, string) EncodeData(EncryptionType type, string text, string key)
    {
        string encodedData;

        switch (type)
        {
            case EncryptionType.Xor:
                encodedData = EncodeXor(text, key);
                break;
            case EncryptionType.Aes:
                encodedData = EncodeAes(text, key);
                break;
            case EncryptionType.Xtea:
                encodedData = EncodeXtea(text, key);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(type), $"No suitable type found: {nameof(type)}");
        }
        var hexBytes = encodedData;
        var hexKey = Convert.ToBase64String(Encoding.UTF8.GetBytes(key));
        return (hexBytes, hexKey);
    }

    public static string CreateMethod(EncryptionType type, string text, string key, string hexBytes, string hexKey)
    {
        string dateTimeStr = DateTime.Now.ToString("yyyyMMddHHmmss");
        var sb = new StringBuilder();
        sb.Append("// Key: " + "'" + key + "'" + "\r\n");
        sb.Append("// String: " + text + "\r\n");
        sb.Append("private static string String" + dateTimeStr + "()" + "\r\n");

        switch (type)
        {
            case EncryptionType.Xor:
                return CreateXorMethod(sb, hexBytes, hexKey);
            case EncryptionType.Aes:
                return CreateAesMethod(sb, hexBytes, hexKey);
            case EncryptionType.Xtea:
                return CreateXteaMethod(sb, hexBytes, hexKey);
            default:
                throw new ArgumentOutOfRangeException(nameof(type), $"No suitable type found: {nameof(type)}");
        }
    }

    private static string CreateAesMethod(StringBuilder sb, string hexBytes, string hexKey)
    {
        sb.Append("{" + "\r\n");
        sb.Append("     // using System.Text;" + "\r\n");
        sb.Append("     // using System.Security.Cryptography;" + "\r\n");
        sb.Append("     byte[] salt = Convert.FromBase64String(\"OTg3NjU0MzIxMDY1NDk4Nw == \");\r\n");
        sb.Append($"    Aes aesAlg = null;\r\n");
        sb.Append($"    Rfc2898DeriveBytes derivedKey = new Rfc2898DeriveBytes(Encoding.UTF8.GetString(Convert.FromBase64String(\"{hexKey}\")), salt);\r\n");
        sb.Append($"    byte[] bytes = Convert.FromBase64String(\"{hexBytes}\");\r\n");
        sb.Append($"    using MemoryStream msDecrypt = new MemoryStream(bytes);\r\n");
        sb.Append($"    aesAlg = Aes.Create(\"AesManaged\");\r\n");
        sb.Append($"    aesAlg.Key = derivedKey.GetBytes(aesAlg.KeySize / 8);\r\n");
        sb.Append($"    byte[] rawLength = new byte[sizeof(int)];\r\n");
        sb.Append($"    msDecrypt.Read(rawLength, 0, rawLength.Length);\r\n");
        sb.Append($"    byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];\r\n");
        sb.Append($"    msDecrypt.Read(buffer, 0, buffer.Length); \r\n");
        sb.Append($"    aesAlg.IV = buffer;\r\n");
        sb.Append($"    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);\r\n");
        sb.Append($"    using CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);\r\n");
        sb.Append($"    using StreamReader srDecrypt = new StreamReader(csDecrypt);\r\n");
        sb.Append($"    return srDecrypt.ReadToEnd();\r\n");
        sb.Append("}" + "\r\n");
        return sb.ToString();
    }

    private static string CreateXteaMethod(StringBuilder stringBuilder, string hexBytes, string hexKey)
    {
        throw new NotImplementedException();
    }

    private static string CreateXorMethod(StringBuilder sb, string hexBytes, string hexKey)
    {
        sb.Append("{" + "\r\n");
        sb.Append("     // using System.Text;" + "\r\n");
        sb.Append($"    byte[] dataBytes = Convert.FromBase64String(\"{hexBytes}\");\r\n");
        sb.Append($"    byte[] keyBytes = Convert.FromBase64String(\"{hexKey}\");\r\n");
        sb.Append($"    for (int i = 0; i < dataBytes.Length; i++)" + "\r\n");
        sb.Append($"        dataBytes[i] ^= (byte)~(uint)keyBytes[i % keyBytes.Length];" + "\r\n");
        sb.Append($"    return Encoding.UTF8.GetString(dataBytes);" + "\r\n");
        sb.Append("}" + "\r\n");
        return sb.ToString();
    }

    private static string EncodeAes(string text, string key)
    {
        Rfc2898DeriveBytes derivedKey = new Rfc2898DeriveBytes(key, salt);
        Aes aes = Aes.Create("AesManaged");
        aes.Key = derivedKey.GetBytes(aes.KeySize / 8);

        ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

        // Create the streams used for encryption.
        using MemoryStream msEncrypt = new MemoryStream();
        // prepend the IV
        msEncrypt.Write(BitConverter.GetBytes(aes.IV.Length), 0, sizeof(int));
        msEncrypt.Write(aes.IV, 0, aes.IV.Length);
        using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
        {
            using (var swEncrypt = new StreamWriter(csEncrypt))
            {
                //Write all data to the stream.
                swEncrypt.Write(text);
            }
        }
        var outStr = Convert.ToBase64String(msEncrypt.ToArray());
        return outStr;
    }

    private static string DecodeAes(string text, string key)
    {
        Aes aesAlg = null;
        Rfc2898DeriveBytes derivedKey = new Rfc2898DeriveBytes(Encoding.UTF8.GetString(Convert.FromBase64String(key)), salt);
        byte[] bytes = Convert.FromBase64String(text);
        using MemoryStream msDecrypt = new MemoryStream(bytes);
        aesAlg = Aes.Create("AesManaged");
        aesAlg.Key = derivedKey.GetBytes(aesAlg.KeySize / 8);
        byte[] rawLength = new byte[sizeof(int)];
        msDecrypt.Read(rawLength, 0, rawLength.Length);
        byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
        msDecrypt.Read(buffer, 0, buffer.Length);
        aesAlg.IV = buffer;
        ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
        using CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
        using StreamReader srDecrypt = new StreamReader(csDecrypt);
        return srDecrypt.ReadToEnd();
    }

    public static void TestEncodeDecodeAes()
    {
        string testStr = "The quick brown fox jumps over the lazy dog";
        string key = "9876543210654987";

        Debug.Assert(DecodeAes(EncodeAes(testStr, key), Convert.ToBase64String(Encoding.UTF8.GetBytes(key))) == testStr);
    }

    private static string EncodeXtea(string text, string key)
    {
        throw new NotImplementedException("Not yet...");
    }

    private static string EncodeXor(string clearText, string key)
    {
        byte[] result = Encoding.UTF8.GetBytes(clearText);
        byte[] keyBytes = Encoding.UTF8.GetBytes(key);
        for (int i = 0; i < result.Length; i++)
        {
            result[i] ^= (byte)~(uint)keyBytes[i % key.Length];
        }

        return Convert.ToBase64String(result);
    }

    private static string DecodeXor(string cypherText, string key)
    {
        byte[] dataBytes = Convert.FromBase64String(cypherText);
        byte[] keyBytes = Convert.FromBase64String(key);
        string result = string.Empty;
        for (int i = 0; i < dataBytes.Length; i++)
            dataBytes[i] ^= (byte)~(uint)keyBytes[i % keyBytes.Length];
        result = Encoding.UTF8.GetString(dataBytes);
        return result;
    }

    public static void TestEncodeDecodeXor()
    {
        string testStr = "The quick brown fox jumps over the lazy dog";
        string key = "9876543210654987";

        Debug.Assert(DecodeXor(EncodeXor(testStr, key), Convert.ToBase64String(Encoding.UTF8.GetBytes(key))) == testStr);
    }

    private static byte[] ReadByteArray(Stream s)
    {
        byte[] rawLength = new byte[sizeof(int)];
        if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
        {
            throw new SystemException("Stream did not contain properly formatted byte array");
        }

        byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
        if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
        {
            throw new SystemException("Did not read byte array properly");
        }

        return buffer;
    }

}