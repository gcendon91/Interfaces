using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program 
    {
        static void Main(string[] args)
        {
            ITest minusculas = new Minusculas();
            ITest mayusculas = new Mayusculas();

            Console.WriteLine(minusculas.HolaMundo());
            Console.WriteLine(mayusculas.HolaMundo());

            Console.WriteLine("------------------------------");

            Console.WriteLine(minusculas.DevolverCadena("Esto es una prueba de INTERFACES"));
            Console.WriteLine(mayusculas.DevolverCadena("Esto es una prueba de INTERFACES"));

            Console.ReadKey();
        }
    }
}
