using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    class Banco
    {
        public List<Conta> listaContas = new List<Conta>();
        public List<Cliente> listaClientes= new List<Cliente>();
        public string Nome { get; set; }

        public Banco(string nome)
        {
            Nome = nome;
        }

        public Cliente procuraCliente(string entradaUsuario)
        {
            foreach (Cliente c in listaClientes)
            {
                if (c.confereCPF(entradaUsuario))
                    return c;
            }

            return null;
        }

        public void criaConta()
        {
            Console.Clear();
            Conta novaConta = new Conta(listaContas.Count);
            listaContas.Add(novaConta);
            Console.WriteLine("Conta criada com sucesso\nAperte qualquer botão para prosseguir.");
            Console.ReadLine();
        }

        public void criaCliente()
        {
            Console.Clear();
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu cpf: ");
            string cpf = Console.ReadLine();

            Cliente novoCliente = new Cliente(nome, cpf);
            listaClientes.Add(novoCliente);
        }

        public void RealizarDeposito()
        {
            Console.WriteLine("Digite Número da Conta p/ Depósito:");
            int entradaUsuario = Convert.ToInt32(Console.ReadLine());
            Conta conta = listaContas.Find(c => c.NumeroDaConta == entradaUsuario);
            if (conta == null)
                throw new Exception("Conta não Encontrada");
            Console.WriteLine("Digite o Valor do Depósito:");
            decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

            conta.Depositar(valorDeposito);
        }

        public void RealizarSaque()
        {
            Console.WriteLine("Digite Número da Conta p/ Saque:");
            int entradaUsuario = Convert.ToInt32(Console.ReadLine());
            Conta conta = listaContas.Find(c => c.NumeroDaConta == entradaUsuario);
            if (conta == null)
                throw new Exception("Conta não Encontrada");

            Console.WriteLine("Digite o valor para saque: ");
            decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

            conta.Sacar(valorSaque);
        }

        public void RealizarTransferencia()
        {
            Console.WriteLine("Digite Número da Conta de origem:");
            int numeroOrigem = Convert.ToInt32(Console.ReadLine());
            Conta contaOrigem = listaContas.Find(c => c.NumeroDaConta == numeroOrigem);
            if (contaOrigem == null)
                throw new Exception("Conta não Encontrada");

            Console.WriteLine("Digite Número da Conta de destino:");
            int numeroDestino = Convert.ToInt32(Console.ReadLine());
            Conta contaDestino = listaContas.Find(c => c.NumeroDaConta == numeroDestino);
            if (contaDestino == null)
                throw new Exception("Conta não Encontrada");

            Console.WriteLine("Digite o valor de transferencia: ");
            decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

            contaOrigem.Sacar(valorTransferencia);
            contaDestino.Depositar(valorTransferencia);

           

        }
    }
}
