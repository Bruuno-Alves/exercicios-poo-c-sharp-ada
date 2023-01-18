using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneClasseAbstrata
{
    public class Motorola : Smartphone
    {
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo {nome} no Motorola...");
        }
    }
}
