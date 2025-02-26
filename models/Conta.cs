using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploPOO.models
{
    public abstract class Conta
    {
        protected decimal saldo;

        public abstract void Creditar(decimal valor);
        
        public void exibirSaldo()
        {
            Console.WriteLine($" O seu Saldo é: {saldo}");
        }
    }
}