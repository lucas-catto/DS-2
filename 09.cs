
using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        // Software de validação de senha
        Console.Write("Digite uma senha:");
        String senha = ValidarSenha(Console.ReadLine());
        
        Console.Write("\nConfirme a senha:");
        String confirmaSenha = ValidarSenha(Console.ReadLine());    
        
        // faz a validação
        bool igual = ComparaTexto(senha, confirmaSenha);
       
        if (igual)
            Console.WriteLine("\nArmazenando dados!");
        else
            Console.WriteLine("\nRefaça o processo");
    }
    
    private static string ValidarSenha(string texto)
    {
        if (texto.Length < 8)
            Console.WriteLine("\nTamanho inválido!");

        if (!texto.Any(char.IsDigit))
            Console.WriteLine("\nNão possui números!");

        if (!texto.Any(char.IsUpper))
            Console.WriteLine("\nNão possui letras maiúsculas!");

        if (!texto.Any(ch => !char.IsLetterOrDigit(ch)))
            Console.WriteLine("\nNão possui caracteres especiais!");

        return texto;
    }
    
    private static bool ComparaTexto(string senha, string confirmaSenha)
    {
        if (senha.Equals(confirmaSenha, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("\nSenhas conferem!");
            return true;
        }
        else
        {
            Console.WriteLine("\nSenhas não conferem!");
            return false;
        }
    }
}