/*
Claro, aqui está o texto dividido em linhas ainda menores:

Imagine que você tenha uma máquina do tempo que pode ser usada no máximo três vezes, e a cada uso da máquina você
pode escolher voltar para o passado ou ir para o futuro.
A máquina possui três créditos fixos; cada crédito representa uma certa quantidade de anos, e pode ser usado para ir
essa quantidade de anos para o passado ou para o futuro.
Você pode fazer uma, duas ou três viagens, e cada um desses três créditos pode ser usado uma vez apenas.
Por exemplo, se os créditos forem 5, 12 e 9, você poderia decidir fazer duas viagens: ir 5 anos para o futuro e,
 depois, voltar 9 anos para o passado.
Dessa forma, você terminaria quatro anos no passado, em 2012.
Também poderia fazer três viagens, todas indo para o futuro, usando os créditos em qualquer ordem, terminando em 2042.
Neste problema, dados os valores dos três créditos da máquina, seu programa deve dizer se é ou não possível
 viajar no tempo e voltar para o presente, fazendo pelo menos uma viagem e, no máximo, três viagens; 
 sempre usando cada um dos três créditos no máximo uma vez.
*/

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