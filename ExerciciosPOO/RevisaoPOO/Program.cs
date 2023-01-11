namespace RevisaoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new("Bruno", 32);
            pessoa.Cumprimentar();
            pessoa.DizerIdade();

            Console.WriteLine("--------------------");

            Aluno aluno = new("Pedro", 21);
            aluno.Cumprimentar();
            aluno.DizerIdade();
            aluno.IrParaEscola();

            Console.WriteLine("--------------------");

            Professor professor = new("Michael", 30);
            professor.Cumprimentar();
            professor.DizerIdade();
            professor.Explicar("construtores");
        }
    }
}