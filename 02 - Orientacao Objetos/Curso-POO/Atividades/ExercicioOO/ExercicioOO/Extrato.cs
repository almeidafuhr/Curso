using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOO
{
    class Extrato
    {
        private string cpfPessoa;
        private string nomePessoa;
        private double valorInicial;
        protected List<RegistroExtrato> movimentacoes;

        Extrato(string cpf, string nome, double valor, List<RegistroExtrato> movimentos)
        {
            cpfPessoa = cpf;
            nomePessoa = nome;
            valorInicial = valor;
            movimentacoes = movimentos;
        }

        public double CalcularSaldo()
        {

            throw new Exception();
        }

        public void ImprimeSaldo()
        {

        }
    }
}
