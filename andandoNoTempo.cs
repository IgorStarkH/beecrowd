using System;

class URI
{
    static void Main(string[] args)
    {
        int a, b, c;
        char resposta;

        string[] split = Console.ReadLine().Split(' ');
        a = int.Parse(split[0]);
        b = int.Parse(split[1]);
        c = int.Parse(split[2]);

        if (a == b || a == c || b == a || b == c || c == a || c == b)
        {
            resposta = 'S';
        }
        else if (a + b == c || a + c == b || b + a == c || b + c == a || c + a == b || c + b == a)
        {
            resposta = 'S';
        }
        else
        {
            resposta = 'N';
        }

        Console.WriteLine(resposta);
    }
}