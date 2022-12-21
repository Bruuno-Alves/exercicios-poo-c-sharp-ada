namespace PessoaGetterSetters
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new();
            pessoa1.PrimeiroNome = "Pedro";
            pessoa1.NomeCompleto = "Pedro Francisco de Moraes";
            pessoa1.Email = "pedroteste1@gmail.com";

            //Formatação da impressão feito através da sobrescrita do método ToString() na classe Pessoa
            Console.WriteLine(pessoa1);
        }
    }
}