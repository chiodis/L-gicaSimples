namespace ProjetoNivelamento.Models
{
    public static class NivelamentoHelper
    {
        public static List<int> ColetarNumeros()
        {
            List<int> numeros = new List<int>();

            while (true)
            {
                Console.Write("Digite um número (> 0 para continuar, < 0 para sair): ");

                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    if (numero < 0)
                        break;

                    numeros.Add(numero);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um número inteiro.");
                }
            }

            return numeros;
        }

        public static void ExibirEstatisticas(List<int> numeros)
        {
            if (numeros.Count == 0)
            {
                Console.WriteLine("\nNenhum número válido foi inserido.");
                return;
            }

            int contador = numeros.Count;
            int soma = numeros.Sum();
            double media = numeros.Average();
            int menor = numeros.Min();
            int maior = numeros.Max();


            Console.WriteLine($"1) Contador de valores válidos: {contador}");
            Console.WriteLine($"2) Soma dos valores válidos informados: {soma}");
            Console.WriteLine($"3) Média dos valores válidos informados: {media:F2}");
            Console.WriteLine($"4) Menor valor válido informado: {menor}");
            Console.WriteLine($"5) Maior valor válido informado: {maior}");
        }
    }
}
