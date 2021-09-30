using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signatures
{
    interface ISignatureFormatter
    {
        public abstract string Format(Account account);
    }

    class FormalSignatureFormatter : ISignatureFormatter
    {
        public string Format(Account account)
        {
            StringBuilder sig = new();
            string line = new ('-', 60);
            sig.AppendLine(line);
            sig.AppendLine(account.LastName);
            sig.AppendLine($"{account.Company}, mail {account.EMail}, tel {account.Phone}");
            sig.AppendLine(line);
            return sig.ToString();
        }
    }

    class InFormalSignatureFormatter : ISignatureFormatter
    {
        public string Format(Account account)
        {
            return $"Mvg {account.FirstName}";
        }
    }

    class EnglishSignatureFormatter : ISignatureFormatter
    {
        public string Format(Account account)
        {
            StringBuilder sig = new();
            string line = new ('-', 60);
            sig.AppendLine(line);
            sig.AppendLine(account.LastName);
            sig.AppendLine($"{account.Company}, mail {account.EMail}, phone +31 {account.Phone.Substring(1)}");
            sig.AppendLine(line);
            return sig.ToString();
        }
    }
}
