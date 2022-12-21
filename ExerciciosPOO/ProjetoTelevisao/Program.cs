namespace ProjetoTelevisao
{
    public class Program
    {
        static void Main(string[] args)
        {
            Televisao televisao = new();

            Console.WriteLine($"A televisão está ligada?: {televisao.Ligada}");
            televisao.Ligar();
            Console.WriteLine($"A televisão está ligada?: {televisao.Ligada}");

            Console.WriteLine($"Volume da televisão: {televisao.Volume}");
            televisao.AumentarVolume();
            televisao.AumentarVolume();
            televisao.AumentarVolume();
            televisao.AumentarVolume();
            Console.WriteLine($"Volume da televisão: {televisao.Volume}");
            televisao.DiminuirVolume();
            televisao.DiminuirVolume();
            Console.WriteLine($"Volume da televisão: {televisao.Volume}");

            televisao.Desligar();
            Console.WriteLine($"A televisão está ligada?: {televisao.Ligada}");
            
        }
    }
}