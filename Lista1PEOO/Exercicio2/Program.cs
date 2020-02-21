using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota dos dois bimestres da disciplina");
            double nota1 = double.Parse(Console.ReadLine());
            double nota2 = double.Parse(Console.ReadLine());
            double media = (nota1 * 2 + nota2 * 3) / 5;
            Console.WriteLine($"Média parcial = {media}");

        }
    }
}
