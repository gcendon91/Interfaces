using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Mayusculas : ITest
    {
        public string DevolverCadena(string s)
        {
            return s.ToUpper();
        }

        public string HolaMundo()
        {
            return ("¡HOLA MUNDO!");
        }
    }
}
