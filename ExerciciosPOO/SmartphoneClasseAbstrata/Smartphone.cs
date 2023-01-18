using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneClasseAbstrata
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }

        public void Ligar()
        {
            Console.WriteLine("Aguarde, Ligando...");
        }

        public void ReceberLigação()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nome);

    }
}
