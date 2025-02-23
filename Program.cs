/**
 * PUC Minas, Campus Barreiro.
 * POO Aula Prática 
 * Data: 12/02/2025 (dia da semana)
 * @author |Lucas Chiodi Reis 
 * Objetivo: FAZER O RP1
*/
using ProjetoNivelamento.Models;   
    
            string opcao = string.Empty;
            bool exibirmenu = true;


            while (exibirmenu)
            {
                Console.Clear();
                Console.WriteLine("1 - Inserir nova sequência de números");
                Console.WriteLine("2 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = Console.ReadLine().Trim();
                 
                if(string.IsNullOrEmpty(opcao))
                {
                    Console.WriteLine("invalida, digite outra opcao");
                    continue;
                }
                
                switch (opcao)
                {
                    case "1":
                        List<int> numeros = NivelamentoHelper.ColetarNumeros();
                        NivelamentoHelper.ExibirEstatisticas(numeros);
                        break;

                    case "2":
                        Console.WriteLine("Encerrando o programa...");
                        exibirmenu = false;
                        break;

                    default:
                        Console.WriteLine("opcao invalida");
                        break;


                }

                Console.WriteLine("pressione uma tecla para continuar");
                Console.ReadLine();

            }
            Console.WriteLine("o programa se encerrou");
        
