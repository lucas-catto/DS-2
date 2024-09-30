
using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        // Sofware de validação de senha
        Console.WriteLine("Digite sua Senha: ");
        string senha = Console.ReadLine();

         // Confirmar Senha
        Console.WriteLine("Confirme sua senha: ");
        string confirmarSenha = Console.ReadLine();

        // Faz a validação
        bool tamanhoValido = senha.Length >= 8;
        bool contemNumero = senha.Any(char.IsDigit);
        bool contemMaiuscula = senha.Any(char.IsUpper);

        // Testa se todos foram positivos
        // O método String.Compare testa se duas strings são iguais se o resultado for 0, isso significa que as strings são iguais caso contrário, elas são diferentes.
        if (tamanhoValido && contemMaiuscula && contemNumero && String.Compare(senha, confirmarSenha) == 0)
        {
            Console.WriteLine("Senha Válida!");
        }
        else if (String.Compare(senha, confirmarSenha) != 0)
        {
            Console.WriteLine("Senhas não conferem!");
        }
        else
        {
            Console.WriteLine("Senha Inválida!");
        }
    }
}