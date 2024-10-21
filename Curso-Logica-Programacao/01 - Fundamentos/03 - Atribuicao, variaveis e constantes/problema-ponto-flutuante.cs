using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_26_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Exemplo soma float {decimal.MaxValue}");

            float somaFloat = 1.1f;

            somaFloat += 0.1f;
            somaFloat += 0.1f;
            somaFloat += 0.1f;
            somaFloat += 0.1f;

            Console.WriteLine($"Resultado da soma do tipo float: {somaFloat:e10}");
            
            decimal somaDecimal = 1.1m;

            somaDecimal += 0.1m;
            somaDecimal += 0.1m;
            somaDecimal += 0.1m;
            somaDecimal += 0.1m;

            Console.WriteLine($"Resultado da soma do tipo decimal: {somaDecimal:e10}");

            Console.ReadLine();
            
        }
    }
}
