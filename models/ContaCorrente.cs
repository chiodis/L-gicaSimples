using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploPOO.models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoinicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoinicial;
        }

        public int NumeroConta { get; set; }
        private decimal saldo;

        public void sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de {valor} efetuado com sucesso. ");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public void exibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {saldo}");
        }
    }
}