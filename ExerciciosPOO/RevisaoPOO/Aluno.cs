using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPOO
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, int idade) : base(nome, idade)
        {
        }

        public void IrParaEscola()
        {
            Console.WriteLine("Estou indo para a escola");
        }
    }
}
