using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTelevisao
{
    public class Televisao
    {
        public int Canal { get; set; }
        public int Volume { get; set; }
        public bool Ligada { get; set; }

        public void Ligar()
        {
            if(!Ligada)
            {
                Ligada = true;
            }
        }

        public void Desligar()
        {
            if(Ligada)
            {
                Ligada = false;
            }
        }

        public void MudarCanal(int canal)
        {
            Canal= canal;
        }

        public void AumentarVolume()
        {
            if(Volume < 96)
            {
                Volume += 5;
            }
        }

        public void DiminuirVolume()
        {
            if(Volume > 4)
            {
                Volume -= 5;
            }
        }
    }
}
