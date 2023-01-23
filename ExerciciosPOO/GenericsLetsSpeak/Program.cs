using System.Runtime.Serialization.Formatters.Binary;

namespace GenericsLetsSpeak
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dicionario<string, string> dicionario = new Dicionario<string, string>();

            if (File.Exists("termosDicionario.bin"))
            {
                using (Stream stream = File.Open("termosDicionario.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    dicionario.Termos = (Dictionary<string, string>)bin.Deserialize(stream);
                }
            }


            Menu.Iniciar(dicionario);
        }
    }
}