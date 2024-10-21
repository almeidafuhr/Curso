using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf;
        public List<Conta> listaContas = new List<Conta>();

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public void AdicionarConta(Conta conta)
        {
            // Validações
            listaContas.Add(conta);
        }

        public Conta DepositarNaConta(decimal valor, int numeroConta)
        {
            var conta = BuscarConta(numeroConta);

            conta.Depositar(valor);

            return conta;
        }

        public Conta SacarDaConta(decimal valor, int numeroConta)
        {
            var conta = BuscarConta(numeroConta);
            conta.Sacar(valor);
            return conta;
        }

        public decimal VisualizarSaldoDaConta(int numeroConta)
        {
            var conta = BuscarConta(numeroConta);
            return conta.VisualizarSaldo();
        }

        public Conta BuscarConta(int numeroConta)
        {
            var conta = listaContas
                .FirstOrDefault(x => x.NumeroDaConta == numeroConta);

            if (conta == null)
            {
                throw new Exception("Conta não encontarda");
            }

            return conta;
        }
    }
}
