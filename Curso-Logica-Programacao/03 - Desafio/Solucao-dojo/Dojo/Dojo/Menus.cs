using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo
{
    class Menus
    {
        public string SolicitarNome()
        {
            Console.Write("Seu Nome: ");
            string nome = Console.ReadLine();
            return nome;
        }

        public string SolicitarCpf()
        {
            Console.Write("Seu CPF: ");
            string cpf = Console.ReadLine();
            return cpf;
        }

        public int SolicitarConta()
        {
            Console.WriteLine("Sua conta: ");
            int conta = Convert.ToInt32(Console.ReadLine());
            return conta;
        }

        public int GerarNumeroConta()
        {
            Random rand = new Random();
            return rand.Next();
        }

        public void MenuPrincipal(Banco b)
        {
            int menu;

            Console.Write("1 - Cadastrar Cliente \n2 - Abrir Conta \n3 - Realizar Operações \nEscolha: ");
            menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:  //Cadastrar cliente
                    string nome = SolicitarNome();
                    string cpf = SolicitarCpf();
                    int conta = GerarNumeroConta();

                    
                    break;
                case 2:  //Abrir Conta
                   


                case 3:  //Realizar Operações
                    
                default:
                    break;
            }
        }

        public void MenuOperacoes(Cliente c)
        {
            Console.Write("1 - Visualizar Saldo \n2 - Sacar \n3 - Transferir \n4 - Depositar \nEscolha: ");

            int menu;
            menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:  //Ver saldo

                    Console.Write("Número da conta: ");
                    int conta = int.Parse(Console.ReadLine());
                    c.VisualizarSaldoDaConta(conta);
                    break;
                case 2:  //Sacar

                    break;
                case 3:  //Transferir

                    break;
                case 4:  //Depositar

                    break;
                default:
                    break;
            }
        }
    }
}
