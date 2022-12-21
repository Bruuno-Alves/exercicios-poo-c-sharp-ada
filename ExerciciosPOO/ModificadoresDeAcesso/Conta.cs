using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcesso
{
    public class Conta
    {
        public int Agencia { get; protected set; } //setter aberto para a classe mãe ou classes filhas
        public int NumeroConta { get; protected set; } //setter aberto para a classe mãe ou classes filhas
        public string Titular { get; set; } //pode ser acessado ou alterado dentro ou fora da classe
        public double Saldo { get; private set;} //o saldo pode ser acessado fora da classe, porém só pode ser configurado dentro da classe

        public Conta(int agencia, int numeroConta)
        {
            Agencia= agencia;
            NumeroConta= numeroConta;
        }

        //métodos públicos podem ser usados fora da classe
        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public Boolean Sacar(double valor)
        {
            if(valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
