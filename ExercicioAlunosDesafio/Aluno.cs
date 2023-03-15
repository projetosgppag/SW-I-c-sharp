namespace ExercicioAlunos;
class Aluno
{
    public string? nome;

    public string pegaNome(){
        System.Console.WriteLine("Digite o nome do aluno abaixo: ");
        nome = Console.ReadLine();
        return nome;
    }

    public int pegaContador(){
        int contador;
        System.Console.WriteLine("Digite a quantia de notas: ");
        contador = Convert.ToInt32(Console.ReadLine());
        return contador;
    }
    public double calculaMedia(int contador){
        double somaN=0, holder;
        for(int x = 0; x<contador; x++){
            System.Console.WriteLine("Digite a nota: ");
            holder = Convert.ToDouble(Console.ReadLine());
            somaN+=holder;
        }
        double media = somaN/contador;
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
    public void mostraDados(double media){
        System.Console.WriteLine("O nome do aluno é: " + nome + " e a média das notas foi: " + media + ", portanto o " + nome + " foi: " + estadoAluno(media));
    }
}