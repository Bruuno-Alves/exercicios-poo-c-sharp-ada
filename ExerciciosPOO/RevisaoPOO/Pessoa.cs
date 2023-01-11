using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPOO
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void Cumprimentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}");
        }

        public void DizerIdade()
        {
            Console.WriteLine($"Eu tenho {Idade} anos");
        }
    }
}
