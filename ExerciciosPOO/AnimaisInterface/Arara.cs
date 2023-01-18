using AnimaisInterface.Classes;
using AnimaisInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaisInterface
{
    public class Arara : Ave, IVoar, IOviparo
    {
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }

        public void Voar()
        {
            Console.WriteLine("Voando");
        }

        public void Botar()
        {
            Console.WriteLine("Botando ovo");
        }

        public void Chocar()
        {
            Console.WriteLine("Chocando ovo");
        }
    }
}
