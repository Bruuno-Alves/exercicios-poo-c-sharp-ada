using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaisInterface.Classes
{
    public class Mamifero : Animal
    {
        public int QuantidadeMamas { get; set; }
        public bool TemPelo { get; set; }
        public string CorPelo { get; set; }

        public void Amamentar()
        {
            Console.WriteLine("Amamentando");
        }
    }
}
