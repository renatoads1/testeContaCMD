using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    public class ContaService : IContaService
    {
        public void CriarConta(IPessoa pessoa, IConta conta)
        {
            Console.WriteLine("Entre com o Número da conta");
            conta.NumeroConta = Console.ReadLine();

            Console.WriteLine("Entre com o Nome do Titular da conta");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Entre com o Deposito da conta");
            if (decimal.TryParse(Console.ReadLine(), out decimal saldo))
            {
                conta.Saldo = saldo;
            }

            Console.WriteLine($"Conta de {pessoa.Nome} \n De número {conta.NumeroConta} \n com saldo de {conta.Saldo:C}");
        }
    }
}
