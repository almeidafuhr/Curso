using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    class Conta
    {

        public decimal Saldo { get; private set; }
        public int NumeroDaConta { get; private set; }
        

        public Conta(int nroConta)
        {
            Saldo = 0;
            NumeroDaConta = nroConta;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor; 
        }

        public void Sacar(decimal valor)
        {
            if (valor - Saldo >= 0)
                Saldo -= valor;
        }

        public void Transferir(decimal valor)
        {
            if (valor - Saldo > 0)
            {

            }
        }


        public void VisulizarSaldo()
        {
            Console.WriteLine($"{Saldo}");
        }


    }
}
