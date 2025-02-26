using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudar.models
{
    public class Pessoa
    {

        public Pessoa()
        {
            
        }

        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;

        }

        private string _nome;
        private int _idade;
        public string Nome
        {
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("o nome nao pode ser vazio");
                }
                _nome = value;
            }
        }
        public string Sobrenome { get; set; }
        //juncao dos dois
        public string NomeCompleto  => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("a idade nao pode ser menor do que zero");
                }

                _idade = value;
            }
        }


         public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é:{NomeCompleto}, e tenho {Idade} anos");
        }
    }
}