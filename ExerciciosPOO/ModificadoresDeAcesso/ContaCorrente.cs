using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcesso
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int agencia, int numeroConta, string titular) : base(agencia, numeroConta)
        {
           Titular= titular;
        }

        public void ConfiguarConta(int agencia, int numeroConta)
        {
            Agencia= agencia;
            NumeroConta= numeroConta;
        }

        public override string ToString()
        {
            return $"Conta Agência: {Agencia}, Conta Número: {NumeroConta}, Titular: {Titular}, Saldo: {Saldo}";
        }
        
    }
}
