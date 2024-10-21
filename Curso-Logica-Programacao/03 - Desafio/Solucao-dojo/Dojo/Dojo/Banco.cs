using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo
{
    public class Banco
    {
        public List<Cliente> listaClientes { get; set; }

        public Banco()
        {
            listaClientes = new List<Cliente>();
        }

        public Cliente criaConta(string nome, string cpf, int numeroConta)
        {
            var cliente = listaClientes
                .FirstOrDefault(x => x.Cpf == cpf);

            if (cliente == null)
            {
                cliente = new Cliente(nome, cpf);
                listaClientes.Add(cliente);
            }

            Conta novaConta = new Conta(numeroConta);
            cliente.AdicionarConta(novaConta);

            return cliente;
        }

        public void TransferirValorEntreContas(Conta origem
            , Conta destino
            , decimal valor)
        {
            origem.Sacar(valor);
            destino.Depositar(valor);
        }
    }
}
