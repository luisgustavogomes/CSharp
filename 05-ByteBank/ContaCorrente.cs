

public class ContaCorrente

{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    public bool Sacar(double valor)
    {

        if (this.saldo < valor || valor <= 0)
        {
            return false;
        }
        
        this.saldo -= valor;
        return true;
        
    }

    public bool Depositar(double valor)
    {
        if (valor > 0)
        {
            this.saldo += valor;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Transferir(ContaCorrente contaCorrenteDestino ,double valor)
    {
        if (this.saldo < valor || valor <= 0 )
        {
            return false;
        }
        
        this.Sacar(valor);
        contaCorrenteDestino.Depositar(valor);
        return true;
        
        
    }


}

