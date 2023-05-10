namespace contrato;
class ContratoPessoaFisica : Contrato
{
    public ContratoPessoaFisica(String? Nome, String? Email, String? Telefone, String? Cpf, int Idade){
        this.Nome = Nome;
        this.Email = Email;
        this.Telefone = Telefone;
        this.Cpf = Cpf;
        this.Idade = Idade;
    }
    public String? Cpf {get; set;}
    public int Idade {get; set;}

    public override void mostraDados(){
        System.Console.WriteLine("Nome: " + this.Nome + "\nEmail: " + this.Email + "\nTelefone: " + this.Telefone + "\nCpf: " + this.Cpf + "\nIdade: " + this.Idade);
    }
    public override string calculaPrest()
    {
        switch (Idade)
        {
        case <=30:
            return "adicional de 1";
        case <= 40:
            return "adicional de 2";
        case <=50:
            return "adicional de 3";
        default:
            return "adicional de 4";
        }
    }
}
