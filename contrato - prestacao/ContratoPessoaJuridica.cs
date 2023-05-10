namespace contrato;
class ContratoPessoaJuridica : Contrato
{
    public ContratoPessoaJuridica(String? Nome, String? Email, String? Telefone, String? Cnpj, String? IE, String? NomeEmpresa){
        this.Nome = Nome;
        this.Email = Email;
        this.Telefone = Telefone;
        this.Cnpj = Cnpj;
        this.IE = IE;
        this.NomeEmpresa = NomeEmpresa;
    }
    public String? Cnpj {get; set;}
    public String? IE {get; set;}
    public String? NomeEmpresa {get; set;}

    public override void mostraDados(){
        System.Console.WriteLine("Nome: " + this.Nome + "\nEmail: " + this.Email + "\nTelefone: " + this.Telefone + "\nCpnj: " + this.Cnpj + "\nIE: " + this.IE + "\nNome da empresa: " + this.NomeEmpresa);
    }
}
