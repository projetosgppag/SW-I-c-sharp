namespace ContaBancariaResolvido;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercicio conta banco   -  ETEC MCM");
        Conta c1 = new Conta();

        c1.nomeCliente = "Anderson Vanin";
      //c1.numeroConta = 123;
        c1.limite = 500;
      //c1.saldo = 5000;

      //System.Console.WriteLine("Ola " + c1.nomeCliente + ", seu saldo equivale a: " + c1.saldo);
      //System.Console.WriteLine("O limite: " + c1.limite + "\nO numero da conta: " + c1.numeroConta);
    
        c1.depositar(200);
        c1.sacar(701); // saldo atual: 200 deposito + 500 limite


        double saldo = c1.consultaSaldo();

    }
}
