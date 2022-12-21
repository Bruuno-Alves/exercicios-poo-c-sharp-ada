namespace ClasseCaneta
{
    public class Program
    {
        static void Main(string[] args)
        {
            Caneta caneta1 = new();
            caneta1.Marca = "BIC";
            caneta1.CorCarga = "azul";
            caneta1.CorTubo = "transparente";
            caneta1.Ponta = 1.0;

            Caneta caneta2 = new();
            caneta2.Marca = "Compactor";
            caneta2.CorCarga = "vermelha";
            caneta2.CorTubo = "branco";
            caneta2.Ponta = 0.7;

            //Formatação da saída dos dados feita através da sobrescrita do método ToString() na classe Caneta
            Console.WriteLine(caneta1);
            Console.WriteLine(caneta2);
        }
    }
}