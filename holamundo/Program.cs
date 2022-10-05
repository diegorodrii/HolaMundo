using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace holamundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String diego = "hola!";
            Console.WriteLine(diego);

            int edad = 25;
            // Console.WriteLine($"Tu edad es de {edad}");
            int alumnos = 24;
            string curso = "DEINT";

            Console.WriteLine("En la clase de {0} hay {1} alumnos", curso, alumnos);
        }
    }
}
