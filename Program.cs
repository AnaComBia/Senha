using System;

namespace Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---Senha---\n");

            Console.Write("\nDigite a senha do usuário: ");
            String senha = Console.ReadLine();

            if (senha == "123abc")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nAcesso permitido\n");
                Console.ResetColor();
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAcesso negado\n");
                Console.ResetColor();
            }


        }
    }
}
