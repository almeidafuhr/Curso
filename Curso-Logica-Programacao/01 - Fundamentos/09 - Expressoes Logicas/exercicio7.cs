using System;

namespace Exercicios_expressoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o 1° número:");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o 2° número:");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o 3° número:");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            if (valor1 > valor2 && valor1 > valor3)
                Console.WriteLine($"O Valor {valor1} é o maior");
            else if (valor2 > valor1 && valor2 > valor3)
                Console.WriteLine($"O Valor {valor2} é o maior");
            else if(valor3 > valor1 && valor3 > valor2 )
                Console.WriteLine($"O Valor {valor3} é o maior");
            else if (valor1 == valor2 && valor1 == valor3 && valor2 == valor3)
                Console.WriteLine($"Os valores são iguais");

            Console.ReadLine();

        }
    }
}
