using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7");

            ContaCorrente conta = new ContaCorrente(876, 87698765);
            Console.WriteLine("Número: " + conta.Numero + 
                           "\nAgencia: " + conta.Agencia);

            Console.WriteLine("Total de contas criadas: "+ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta2 = new ContaCorrente(876, 87698765);
            Console.WriteLine("Número: " + conta2.Numero +
                           "\nAgencia: " + conta2.Agencia);

            Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);





            Console.ReadLine();
        }
    }
}
