namespace animais;
class Program
{
    static void Main(string[] args)
    {
        Homem pessoinha = new Homem();
        Dog caramelo = new Dog();
        Katze stella = new Katze();  // Stella é o nome da minha gata

        System.Console.WriteLine("O homem diz: " + pessoinha.falar());
        System.Console.WriteLine("O cachorro diz: " + caramelo.falar());
        System.Console.WriteLine("E, o gato diz: " + stella.falar());
    }
}
