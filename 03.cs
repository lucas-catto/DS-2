
using System;

public class Sorteio
{
    public static void Main(string[] args)
    {
        var numeroSorteado = new System.Random().Next(0, 10);
        
        Console.WriteLine("COLINHA: " + numeroSorteado);
        
        int i = 3;
        
        while (true) {
            Console.WriteLine("Numero de tentativas: " + i);
            
            string userInput = Console.ReadLine();
            int userInputInt;

            try
            {
                userInputInt = Int32.Parse(userInput);
            }
            catch(Exception e)
            {
                Console.WriteLine("Digite um valor valido!");
                continue;
            }
            
            
            if (userInputInt < 0 || userInputInt > 10)
            {
                Console.WriteLine("Digite um numero entre 0 e 10.");
                continue;
            }

            if (numeroSorteado == userInputInt)
            {
                Console.WriteLine("Parabens, voce acertou!!");
                break;
            }

            else if (numeroSorteado != userInputInt)
            {
                i--;
                if (i == 0)
                {
                    Console.WriteLine("Nao foi dessa vez!");
                    break;
                }
                Console.WriteLine("Errou tente novamente.");
            }
        }
    }
}
