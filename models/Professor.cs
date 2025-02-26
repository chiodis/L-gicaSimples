using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploPOO.models
{
    public class Professor :  Pessoa    
    {
        public Professor()
        {
        }

        public Professor(string nome) : base(nome)
        {
            
        }
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Ola meu nome é {Nome}, tenho {Idade} anos e meu salario é {Salario}");
        }
    }
}