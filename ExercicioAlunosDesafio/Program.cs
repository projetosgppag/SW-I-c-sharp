namespace ExercicioAlunos;
class Program
{
    static void Main(string[] args)
    {
        Aluno a1 = new Aluno();
        a1.pegaNome();
        a1.mostraDados(a1.calculaMedia(a1.pegaContador()));
    }
}
