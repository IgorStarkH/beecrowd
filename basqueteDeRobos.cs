/*
A organização da OIBR, Olimpíada Internacional de Basquete de Robô, está começando a ter problemas com dois times:
os Bit Warriors e os Byte Bulls.
É que os robôs desses times acertam quase todos os lan- çamentos, de qualquer posição na quadra!
Pensando bem, o jogo de basquete ficaria mesmo sem graça se jogadores conseguissem acertar qualquer lançamento.

Uma das medidas que a OIBR está implantando é uma nova pontuação para os lançamentos, de acordo com a distância do robô 
para o início da quadra.
A quadra tem 2000 centímetros de comprimento, como na figura.
*/

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