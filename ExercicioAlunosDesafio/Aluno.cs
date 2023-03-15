namespace ExercicioAlunos;
class Aluno
{
    public string? nome;
    public double nota1;
    public double nota2;

    public double obterMedia(){

        double media = (nota1+nota2)/2;
        return media;
    }
    public string estadoAluno(double media){ //obterSituacao

        string situacao;
        if(media>=6){
        situacao="aprovado";
        }else{
        situacao="reprovado";
        }
        
        return situacao;
    }
    public void mensagem(){
        double mediaCalculada = obterMedia();
        string resultadoSituacao = estadoAluno(mediaCalculada);
        System.Console.WriteLine(nome+" está " + resultadoSituacao + " com média de: "+mediaCalculada);
    }

    // desafio aqui, 3 metodos aonde os 3 serao: pegaNome, fazTudoInator3.0 e mostraDados.

    public string pegaNome(){
        System.Console.WriteLine("Digite o nome do aluno abaixo: ");
        string? nome2 = Console.ReadLine();
        return nome2;
    }

    public double pegaQuantiaNotasERetornaMedia(){
        int contador;
        double somaN=0, holder;
        System.Console.WriteLine("Digite a quantia de notas: ");
        contador = Convert.ToInt32(Console.ReadLine());
        for(int x = 0; x<contador; x++){
            System.Console.WriteLine("Digite a nota: ");
            holder = Convert.ToDouble(Console.ReadLine());
            somaN+=holder;
        }
        double media = somaN/contador;
        return media;
    }
    public void mostraDados(){
        System.Console.WriteLine("O nome do aluno é: " + nome + " a média das notas foi: " + pegaQuantiaNotasERetornaMedia());
    }

    //construtor ebaaaa
    
    /*
    public Aluno(string nome, double nota1, double nota2){

        this.nome = nome;
        this.nota1 = nota1;
        this.nota2 = nota2;
    }
    */
}