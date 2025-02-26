using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exemploPOO.interfaces;

namespace exemploPOO.models
{
    //calculadora implementa a interface ICalculadora
    //para instanciar devemos usar a interface a implementando ": ICalculadora"
    public class Calculadora : ICalculadora
    {
        

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2; 
        }
    }
}