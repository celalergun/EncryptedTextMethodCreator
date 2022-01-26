# EncryptedTextMethodCreator
I love codes that generate codes. This is a simple utility to create C# methods for embedding strings into C# code that cannot be easily changed with hex editors. Also the embedded text cannot be recovered by utilities like 'strings' etc.

You can test newly created method in a C# interactive window just like that: 

```
Microsoft (R) Visual C# Interactive Compiler version 4.0.1-1.21568.1 ()
Loading context from 'CSharpInteractive.rsp'.
Type "#help" for more information.
> using System.Text;
> private static string String20220126163426()
. {
.     byte[] dataBytes = Convert.FromBase64String("7qTorPWw1Pu1r6G9+PWp+Nyj9azusNDora+sufLw56zSqa3g5b/EuLrgpA==");
.     byte[] keyBytes = Convert.FromBase64String("RTNyc3s6QmchcDwwaH04Jw==");
.     for (int i = 0; i < dataBytes.Length; i++)
.         dataBytes[i] ^= (byte)~(uint)keyBytes[i % keyBytes.Length];
.     return Encoding.UTF8.GetString(dataBytes);
. }
> Console.WriteLine(String20220126163426());
The quick brown fox jumps over the lazy dog
> 
```
TODO: XTEA method is not implemented yet.
