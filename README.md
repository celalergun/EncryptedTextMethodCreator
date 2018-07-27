# EncryptedTextMethodCreator
A simple program to embed strings into C# code that cannot be changed with hex editors.


You can test newly created method in a C# interactive window just like that: 

```
    .Microsoft (R) Roslyn C# Compiler version 1.3.4.60902
    .Loading context from 'CSharpInteractive.rsp'.
    .Type "#help" for more information.
    .> private string String20170907092356()
    . {
    .     uint[] _data = { 0x2C, 0xD, 0x8, 0x33, 0x1A, 0x1C, 0x3D, 0x15C, 0x5, 0x49, 0x44, 0x8, 0xA, 0x37, 0x48, 0x31, 0x1D, 0x17B, 0x153, 0x28, 0x57, 0x122, 0x3E, 0xB, 0xD3, 0x53, 0x40, 0x5B, 0x99, 0x37, 0xA, 0x3D, 0x1F, 0x5, 0x9, 0x72, 0x10, 0x81, 0x27, 0x8, 0x4B, 0x45, 0x4C, 0x55, };
    .     uint[] _key = { 0xFFFFFF83, 0xFFFFFF9B, 0xFFFFFF9D, 0xFFFFFFAD, 0xFFFFFF88, 0xFFFFFF82, 0xFFFFFFAE, 0xFFFFFF92, 0xFFFFFFDA, 0xFFFFFFDE, 0xFFFFFFDA, 0xFFFFFF84, 0xFFFFFF81, 0xFFFFFFA9, 0xFFFFFF97, 0xFFFFFFB7, };
    .     string _result = string.Empty;
    .     for (int i = 0; i < _data.Length; i++)
    .         _result += (char)(_data[i] ^ ~_key[i % _key.Length]);
    .     return _result;
    . }
    > String20170907092356()
    "Pijamalı hasta yağız şoföre çabucak güvendi."
    > 
```
TODO: AES method is not implemented yet.
