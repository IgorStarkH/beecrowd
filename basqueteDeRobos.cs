using System;

class URI
{

    static void Main(string[] args)
    {

        int D = int.Parse(Console.ReadLine());
        int cesta = 0;

        if (D <= 800)
        {
            cesta += 1;
        }
        else if (D > 800 && D <= 1400)
        {
            cesta += 2;
        }
        else
        {
            cesta += 3;
        }

        Console.WriteLine(cesta);

    }

}