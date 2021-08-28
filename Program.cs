using System;
using System.Globalization;

namespace SenhaLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua senha para login");
            string digitado = Console.ReadLine();
            string senha = digitado.ToUpper(new CultureInfo("br-BR", false));

            while (senha != "AMOR")
            {
                Console.WriteLine("Senha incorreta!");
                Console.WriteLine("Digite sua senha para login");
                digitado = Console.ReadLine();
                senha = digitado.ToUpper(new CultureInfo("br-BR", false));
            }
            Console.WriteLine("Acesso Autorizado");
        }
    }
}

