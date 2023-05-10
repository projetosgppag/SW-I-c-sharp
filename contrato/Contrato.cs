namespace contrato;
class Contrato
{
    public String? Nome {get;set;}
    public String? Email {get;set;}
    public String? Telefone {get;set;}

    public virtual void mostraDados(){
        System.Console.WriteLine("Nome: " + this.Nome + "\nEmail: " + this.Email + "\nTelefone: " + this.Telefone);
    }
}
