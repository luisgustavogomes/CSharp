using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaLuis = new ContaCorrente();

            Console.WriteLine("Saldo: " + contaLuis.saldo);
            Console.WriteLine("Status: " + contaLuis.Depositar(150));
            Console.WriteLine("Saldo: " + contaLuis.saldo);

            Console.WriteLine("-----------------------------------------");

            ContaCorrente contaMonique = new ContaCorrente();
            Console.WriteLine("Saldo: " + contaMonique.saldo);

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Status: " + contaLuis.Transferir(contaMonique,150));
            Console.WriteLine("Saldo do Luis: " + contaLuis.saldo);
            Console.WriteLine("Saldo da Monique: " + contaMonique.saldo);





            Console.ReadLine();
        }
    }
}
