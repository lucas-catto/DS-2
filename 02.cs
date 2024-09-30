
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
         * CONVENÇÕES
         * 1ª Nome da variavel SEMPRE começa com letra minuscula.
         * 2ª Funções e Métodos sempre possuem parenteses, geralmente começa com letra minuscula.
         * 3ª Classes sempre começam com letra Maiuscula.
        */
        
        /*
         * Elabore um programa que:
         * Sortei um numero de 0 a 10;
         * Solicite ao usuário em 3 tentativas qual numero ele acha que foi sorteado.
         * Conte quantas tentativas o usuario está fazendo.
         * Caso ele acerte, apresente o numero e a quantidade de tentativas
         * Caso ele não acerte nas 3 tentativas, avise que perdeu e informe o numero sorteado.
         * Caso o usuario digite um numero que não esteja na faixa, solicite um novo numero e não conte a tentativa.
         */
        
        // Instancia a classe que gera numero randomicos
        Random random = new Random();

        // Gera um número aleatório de 0 a 10
        int numeroAleatorio = random.Next(0, 11); 
        int tentativas = 1;

        Console.WriteLine($"=============== O GRANDE SORTEIO ================");
        
        // Console.WriteLine($"Numero Sorteado: {numeroAleatorio}");
        
        while(tentativas < 4)
        {
            Console.WriteLine($"Tente acertar o numero sorteado...");
            Console.WriteLine($"Voce possui [ {4 - tentativas} ] tentativa(s)");
            Console.Write($"Digite um numero de 0 a 10: ");

            try
            {
                int numeroDigitado = int.Parse(Console.ReadLine());

                if (numeroDigitado > -1 && numeroDigitado < 11)
                {
                    if (numeroDigitado == numeroAleatorio)
                    {
                        Console.WriteLine($"\n\nParabens!!!\nVocê acertou o número em [ {tentativas} ] tentativa(s)");
                        tentativas = 4;
                    }
                    else
                    {
                        Console.WriteLine($"Errou, tente novamente!");
                         
                        if(tentativas == 3)
                        {
                            Console.WriteLine($"\n\nPERDEUUUUUUU!!!!!");
                        }
                    }
                    tentativas++;
                }
                else
                {
                    Console.WriteLine($"BURRO!!! Numero de 0 a 10!");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("INDIOTA, digite apenas numeros");
            }
            Console.WriteLine("");
        }
    }
}