using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();

            Console.WriteLine("Saldo: " + contaCorrente.saldo);
            Console.WriteLine("Status: " + contaCorrente.Sacar(150));
            Console.WriteLine("Saldo: " + contaCorrente.saldo);

            Console.ReadLine();


        }
    }
}
