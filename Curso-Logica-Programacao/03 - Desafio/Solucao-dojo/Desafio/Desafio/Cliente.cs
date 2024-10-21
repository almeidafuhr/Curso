using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    class Cliente
    {
        public List<Conta> listaContas = new List<Conta>();
        public string Nome { get; set; }
        public string Cpf;

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public bool confereCPF(string c)
        {
            if (c == Cpf)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ExecutaMenuCliente(Banco banco)
        {
            Console.Write("1.Criar conta" +
                "2.Acessar minhas contas" +
                "\n\n3. Para voltar para o menu principal" +
                "OPÇÃO: ");
            int opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                    banco.criaConta();
                    Program.Menu();
                    break;
                case 2:
                    Console.WriteLine("Lista de contas:\n");
                    foreach(Conta c in listaContas)
                    {
                        Console.WriteLine(c.NumeroDaConta);
                    }
                    break;
                case 0:
                    Program.Menu();
                    break;
            }

        }
    }
}
