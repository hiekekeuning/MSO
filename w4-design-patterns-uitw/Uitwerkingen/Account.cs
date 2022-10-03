using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signatures
{
    class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
        public string EMail { get; set; }

        public ISignatureFormatter DefaultSig { get; set; }

        public string MakeSignature()
        {
            if (DefaultSig != null)
            {
                return DefaultSig.Format(this);
            }
            else throw new Exception("Unknown signature format");
        }
    }
}
