using System;

class URI
{

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int qtdPecas = ((N + 1) * (N + 2)) / 2;
        Console.WriteLine(qtdPecas);

    }

}