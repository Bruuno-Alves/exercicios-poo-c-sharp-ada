using AnimaisInterface.Classes;
using AnimaisInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaisInterface
{
    internal class DragaoDeComodo : Reptil, IOviparo, IAquatico
    {
        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }

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
