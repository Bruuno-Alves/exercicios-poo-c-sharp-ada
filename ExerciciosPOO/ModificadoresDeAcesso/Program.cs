namespace ModificadoresDeAcesso
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new(225, 153663, "Bruno");
            conta1.Depositar(100);

            //Formatação da saída dos dados feita através da sobrescrita do método ToString() na classe Conta
            Console.WriteLine(conta1);
        }
    }
}