using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _06_ByteBank
{
    public class ContaCorrente

    {
        public Cliente Cliente { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _saldo = value;
            }

        }



        public bool Sacar(double valor)
        {

            if (_saldo < valor || valor <= 0)
            {
                return false;
            }

            _saldo -= valor;
            return true;

        }

        public bool Depositar(double valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(ContaCorrente contaCorrenteDestino, double valor)
        {
            if (_saldo < valor || valor <= 0)
            {
                return false;
            }
            Sacar(valor);
            contaCorrenteDestino.Depositar(valor);
            return true;
        }

    }

}
