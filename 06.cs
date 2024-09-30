
using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        // Software de validação de senha
        Console.Write("Digite uma senha:");
        String senha = Console.ReadLine();
        
        Console.Write("\nConfirme a senha:");
        String confirmaSenha = Console.ReadLine();    
        
        // faz a validação
        bool tamanhoValido = senha.Length >= 8;
        bool contemNumero = senha.Any(char.IsDigit);
        bool contemMaiuscula = senha.Any(char.IsUpper);
        
        // faz a validação da confirmação
        bool tamanhoValido2 = confirmaSenha.Length >= 8;
        bool contemNumero2 = confirmaSenha.Any(char.IsDigit);
        bool contemMaiuscula2 = confirmaSenha.Any(char.IsUpper);
        
        
        // testa se todos foram positivos
        if (tamanhoValido && contemMaiuscula && contemNumero)
        {
            Console.WriteLine("Senha Valida!");
        }
        else
        {
            Console.WriteLine("Senha Invalida!");
        }

        // testa se todos foram positivos
        if (tamanhoValido2 && contemMaiuscula2 && contemNumero2)
        {
            Console.WriteLine("Confirmação de Senha Valida!");
        }
        else
        {
            Console.WriteLine("Confirmação de Senha Invalida!");
        }

        if(senha == confirmaSenha)
        {
            Console.WriteLine("Senhas conferem!");
        }
        else 
        {
            Console.WriteLine("Senhas não conferem!");
        }
    }
}
