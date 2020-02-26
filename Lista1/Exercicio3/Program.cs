using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            Console.WriteLine("Digite o raio de um círculo:");
            double raio = double.Parse(Console.ReadLine());
            double c = 2 * pi * raio;
            double a = pi * (raio * raio);
            Console.WriteLine($"Circunferência = {c:.00}");
            Console.WriteLine($"Área = {a:.00}");
        }
    }
}
