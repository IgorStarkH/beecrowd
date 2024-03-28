using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha = "2002";
            Console.WriteLine("Digite a senha:");
            string x = Console.ReadLine();
            while (x != senha)
            {
                Console.WriteLine("Senha Invalida");
                x = Console.ReadLine();
            }
            Console.WriteLine("Acesso Permitido");
            
        }
    }
}
