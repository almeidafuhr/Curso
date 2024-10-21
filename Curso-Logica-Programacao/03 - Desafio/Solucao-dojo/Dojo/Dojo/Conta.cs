using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo
{
    public class Conta
    {
        private decimal Saldo { get; set; }
        public int NumeroDaConta { get; private set; }

        public Conta(int nroConta)
        {
            Saldo = 0;
            NumeroDaConta = nroConta;
        }

        public void Depositar(decimal valor)
        {
            if(valor > 0)  // validar se valor é maior que zero
                Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (Saldo - valor < 0)
            {
                throw new Exception("Saldo indisponivel");
            }
            Saldo -= valor;
        }

        public decimal VisualizarSaldo()
        {
            return Saldo;
        }
    }
}
