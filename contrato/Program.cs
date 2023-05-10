namespace contrato;
class Program
{
    static void Main(string[] args)
    {
        ContratoPessoaFisica pessoa = new ContratoPessoaFisica("Davi", "Email@gmail.com", "123456789-10", "123456789-11", 15);
        ContratoPessoaJuridica pj = new ContratoPessoaJuridica("Felipe", "Email@gmail.com", "123456789-10", "123456789-110", "eu não faço a menor ideia do que colocar aqui", "Informatica333");

        pessoa.mostraDados();
        pj.mostraDados();
    }
}
