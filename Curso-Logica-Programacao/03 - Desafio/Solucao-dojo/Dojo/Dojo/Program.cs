using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeroConta = 1;
            var numeroSegundaConta = 2;
            var banco = new Banco();
            var cliente = banco.criaConta("Teste1", "123456789", numeroConta);
            banco.criaConta("Teste1", "123456789", numeroSegundaConta);

            var contaDeposito = cliente.DepositarNaConta(1000, numeroConta);

            if (contaDeposito.VisualizarSaldo() != 1000)
                throw new Exception("Falhou deposito");

            var contaSaque = cliente.SacarDaConta(100, numeroConta);

            if (contaSaque.VisualizarSaldo() != 900)
                throw new Exception("Falhou saque");

            if (banco.listaClientes.Count() == 0)
                throw new Exception("Falhou criar cliente");

            if (cliente.listaContas.Count() != 2)
                throw new Exception("Falhou criar conta");

            banco.TransferirValorEntreContas(
                cliente.BuscarConta(numeroConta)
                , cliente.BuscarConta(numeroSegundaConta)
                , 100);

            if (cliente.BuscarConta(numeroConta).VisualizarSaldo() != 800)
                throw new Exception("Falhou transferencia");

            if (cliente.BuscarConta(numeroSegundaConta).VisualizarSaldo() != 100)
                throw new Exception("Falhou transferencia");

            
           
            
        }
    }
}
