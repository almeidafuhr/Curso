using System;

namespace Exercicios_expressoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Maior número 120 ou 130");
            Console.WriteLine(MaiorNumero(120, 130));

            Console.WriteLine("O valor 36 é par");
            Console.WriteLine(VerificaPar(36));

            ExibeInformacoesUsuarioFormatadas();


            Console.ReadLine();           
        }


        static int MaiorNumero(int valor1, int valor2)
        {
            if (valor1 > valor2)
                return valor1;
            else if (valor2 > valor1)
                return valor2;
            else
                return valor1;
        }

        static bool VerificaPar(int valor)
        {
            if (valor % 2 == 0)
                return true;
            else
                return false;
        }

        static void ExibeInformacoesUsuarioFormatadas()
        {

            Console.WriteLine("Digite seu nome:");
            string nomeUsuario = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Seu nome é: {nomeUsuario}");
            Console.WriteLine($"E sua idade é {idade}");
        }
        
    }
}
