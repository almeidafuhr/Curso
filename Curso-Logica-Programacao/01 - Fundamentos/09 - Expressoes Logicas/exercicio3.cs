using System;

namespace Exercicios_expressoes
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string usuario = "admin";
            string senha = "1234";
            Console.WriteLine("Digite seu usuário:");
            string usuarioEntrada = Console.ReadLine();

            Console.WriteLine("Digite sua senha:");
            string senhaEntrada = Console.ReadLine();

            if(usuarioEntrada.Equals(usuario) && senhaEntrada.Equals(senha))
            {
                Console.WriteLine("Login bem-sucedido");
            } else
            {
                Console.WriteLine("Nome de usuário ou senha incorretos");
            }

            Console.ReadLine();

        }
    }
}
