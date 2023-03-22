namespace ContaBancariaResolvido;
class Conta
{
    public string? nomeCliente {get; set;}
    public int numeroConta {get; set;}
    private double saldo {get; set;}
    public double limite{get; set;}


    public void depositar(double valor){this.saldo += valor;}

    public double consultaSaldo(){
        return this.saldo + this.limite;
    }

    public void sacar(double valor){
        if(this.consultaSaldo()>=valor){
            this.saldo -= valor;
            System.Console.WriteLine("Saque realizado com sucesso, saldo atual disponivel: " + (this.saldo + this.limite));
        }else{
            System.Console.WriteLine("Saldo insuficiente, impossivel realizar este saque.");

        }
    }
}       