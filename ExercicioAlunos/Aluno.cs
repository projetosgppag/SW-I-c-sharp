namespace ExercicioAlunos;
class Aluno
{
    public string nome;
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

    //construtor ebaaaa

    public Aluno(string nome, double nota1, double nota2){

        this.nome = nome;
        this.nota1 = nota1;
        this.nota2 = nota2;
    }

}