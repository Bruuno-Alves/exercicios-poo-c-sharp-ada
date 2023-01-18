using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaisInterface.Classes
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public int Idade { get; set; }
        public bool Carnivoro { get; set; }
        public bool Peconhento { get; set; }

        public void Movimentar()
        {
            Console.WriteLine("Se movimentando");
        }

        public void Comunicar()
        {
            Console.WriteLine("Se comunicando");
        }

        public void Alimentar()
        {
            Console.WriteLine("Se alimentando");
        }
    }
}
