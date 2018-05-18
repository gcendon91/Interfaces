using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Minusculas : ITest
    {
        public string DevolverCadena(string s)
        {
            return s.ToLower();
        }

        public string HolaMundo()
        {
            return ("¡hola mundo!");
        }
    }
}
