using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Desafio
{
    public class Program
    {
        static Banco banco = new Banco("Banrisul");
        static void Main(string[] args)
        {

            Menu();
            
        }

        public static void Menu(){

            Console.WriteLine("MENU\n1.criar cliente\n2.Login cliente");
            Console.Write("OPÇÃO: ");
            char inputUsuario = Convert.ToChar(Console.ReadLine());

            switch (inputUsuario)
            {
                case '1':
                    banco.criaCliente();
                    Menu();
                    break;
                case '2':
                    Console.Write("INFORME O CPF: ");
                    string entradaCPF = Console.ReadLine();
                    Cliente c = banco.procuraCliente(entradaCPF);
                    c.ExecutaMenuCliente(banco);
                    Console.WriteLine($"{c.Nome}");
                    break;

                case '3':
                    break;
            }
            Console.ReadKey();
        }
    }
}
