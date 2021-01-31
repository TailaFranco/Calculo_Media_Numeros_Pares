using System;


namespace Media_numeros_pares
{
    class Program
    {
        static void Main(string[] args)
        {   // Declaração de variáveis;
            string resposta = "sim";
            int dividendo =0;
            int Media;
            int soma =0;
            int n;
            
            // Estrutura de repetição utilizando for;
            // Enquanto a resposta for diferente de "não", continuará pedindo valores de números inteiros;
            Console.WriteLine($"Calculo da média de n números inteiros digitados, somente serão validados os números pares");
            for (var i = 0; resposta!= "não"; i++)
            {
                Console.WriteLine($"Digite números inteiros para iniciar");
                Console.WriteLine($"Digite o {i+1}° número");
                n= int.Parse(Console.ReadLine());
                Console.WriteLine($"Você gostaria de adicionar mais números? Responda apenas sim ou não");
                resposta = Console.ReadLine();
                if(n%2 == 0)
                {
                Console.WriteLine($"Sera utilizado para calculo da média");
                soma = soma + n;
                // A cada valor válido é adicionado o valor n, na soma;
                dividendo++;
                // A cada valor válido é adicionado mais 1 ao valor do dividendo;
                }
                else{
                    // Não adiciona nenhum dado;
                }
                
            }
            // Calculo da média dos números pares;
            Media = soma / dividendo;

            // Escreve uma linha com o resultado da média;
              Console.WriteLine($"A média dos número pares é: {Media}");
              
        }
    }
}
