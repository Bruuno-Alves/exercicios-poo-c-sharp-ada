using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTelevisaoConstrutor
{
    public class Televisao
    {
        public int Canal { get; set; }

        private int volume;
        public int Volume {
            get { return this.volume; }
            private set
            {
                if(value >= 0 && value <= 100)
                {
                    this.volume = value;
                }
                else
                {
                    this.volume = 50;
                }
            }
        }

        public bool Ligada { get; set; }

        public Televisao()
        {
            Canal = 10;
            Volume = 50;
            Ligada = false;
        }

        public Televisao(int canal, int volume, bool ligada)
        {
            Canal = canal;
            Volume = volume;
            Ligada = ligada;
        }

        public void Ligar()
        {
            if (!Ligada)
            {
                Ligada = true;
            }
        }

        public void Desligar()
        {
            if (Ligada)
            {
                Ligada = false;
            }
        }

        public void MudarCanal(int canal)
        {
            Canal = canal;
        }

        public void AumentarVolume()
        {
            if (Volume < 96)
            {
                Volume += 5;
            }
        }

        public void DiminuirVolume()
        {
            if (Volume > 4)
            {
                Volume -= 5;
            }
        }
    }
}
