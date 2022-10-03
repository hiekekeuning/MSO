using Signatures;
using System;

Account acc1 = new()
{
    FirstName = "Rianne",
    LastName = "Jansen",
    Company = "AlbertH",
    EMail = "rianne@alberth.nl",
    Phone = "0612345678",
};
acc1.DefaultSig = new FormalSignatureFormatter();
Console.WriteLine(acc1.MakeSignature());
acc1.DefaultSig = new InFormalSignatureFormatter();
Console.WriteLine(acc1.MakeSignature());
acc1.DefaultSig = new EnglishSignatureFormatter();
Console.WriteLine(acc1.MakeSignature());

