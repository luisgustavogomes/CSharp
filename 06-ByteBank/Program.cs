using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6");
            ContaCorrente conta = new ContaCorrente();
            Cliente cli = new Cliente();
            cli.Nome = "Luis";
            cli.Cpf = "999.999.999-99";
            cli.Profissao = "Desenvolvedor";

            conta.Cliente = cli;

            Console.WriteLine(conta.Cliente.Nome);
            conta.Saldo = 1000;
            Console.WriteLine(conta.Saldo);
            Console.ReadLine();
        }
    }
}
