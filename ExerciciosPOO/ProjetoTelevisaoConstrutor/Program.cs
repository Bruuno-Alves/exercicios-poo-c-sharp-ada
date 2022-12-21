namespace ProjetoTelevisaoConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ao tentar instanciar uma televisão com volume acima de 100, o construtor automaticamente atribui o valor 50 ao volume
            Televisao televisao = new(20, 300, false);

            Console.WriteLine(televisao.Volume);
        }
    }
}