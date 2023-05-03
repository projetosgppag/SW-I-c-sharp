namespace pasta;
class Program
{
    static void Main(string[] args)
    {
        FuncN1 n1 = new FuncN1();
        FuncN2 n2 = new FuncN2();
        FuncN3 n3 = new FuncN3();

        n1.Nome = "Fulano";
        n2.Nome = "Ciclano";
        n3.Nome = "Ze";

        Console.WriteLine("nome: " + n1.Nome + " lucro: " + n1.Lucro());
        Console.WriteLine("nome: " + n2.Nome + " lucro: " + n2.Lucro());
        Console.WriteLine("nome: " + n3.Nome + " lucro: " + n3.Lucro());
    }
}