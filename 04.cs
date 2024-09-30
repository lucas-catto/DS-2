
using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        // Software de validação de senha
        Console.Write("Digite uma senha:");
        string senha = ValidarSenha(Console.ReadLine());

        Console.WriteLine("\nConfirme a senha:");
        string confirmaSenha = ValidarSenha(Console.ReadLine());

        bool igual = ComparaTexto(senha, confirmaSenha);

        if (igual)
            Console.WriteLine("\nArmazenando dados!");
        else
            Console.WriteLine("\nRefaca o processo!");
    }


    private static string ValidarSenha(string texto)
    {
        if (texto.Length < 8)
            Console.WriteLine("Tamanho invalido!");

        if (!texto.Any(char.IsDigit))
            Console.WriteLine("Nao possui numeros!");

        if (!texto.Any(char.IsUpper))
            Console.WriteLine("Nao possui letra maiuscula!");

        return texto;
    }

    private static bool ComparaTexto(string senha, string confirmaSenha)
    {
        if (senha == confirmaSenha)
        {
            Console.WriteLine("\nSenhas conferem!");
            return true;
        }
        else
        {
            Console.WriteLine("\nSenhas nao conferem!");
            return false;
        }
    }
}
