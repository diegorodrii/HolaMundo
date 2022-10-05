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
            //  String diego = "hola!";
            // Console.WriteLine(diego);

            //  int edad = 25;
            // Console.WriteLine($"Tu edad es de {edad}");
            //   int alumnos = 24;
            //  string curso = "DEINT";

            // Console.WriteLine("En la clase de {0} hay {1} alumnos", curso, alumnos);

            Console.WriteLine("Introduce el valor para un radio: ");
            double radio = int.Parse(Console.ReadLine());

            const double PI = 3.14;
            double area = PI * Math.Pow(radio, 2);

            Console.WriteLine($"El valor del área de radio {radio} es {area}");










        }
    }
}
