using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    class CoffeeAppException : Exception
    {
        public CoffeeAppException(string msg): base(msg)
        {

        }
    }
}
