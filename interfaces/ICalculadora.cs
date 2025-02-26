using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploPOO.interfaces
{
    public interface ICalculadora
    {
        //por padrao os metodos de uma interface sao publicos e abstratos
        // é um contrato, tudo que ela tem deve ser implementado na classe que a implementa

        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        
        // aqui nos temos um metodo padrao que pode ser implementado ou nao
        // se nao implementar, ele vai usar o metodo padrao
        //se torna opcional a sua implementacao
        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

    }
}