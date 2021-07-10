using System;
using tabuleiro;
using tabuleiro.Enums;
using tabuleiro.Exceptions;
using xadrez;

namespace XadrezC_
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            PartidaDeXadrez partida = new PartidaDeXadrez();

            while (!partida.Terminada)
            {
                Console.Clear();
                Tela.ImprimirTabuleiro(partida.Tab);

                System.Console.Write("\nOrigem: ");
                Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                System.Console.Write("Destino: ");
                Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                partida.ExecutarMovimento(origem,destino);
            }

            Tela.ImprimirTabuleiro(partida.Tab);
            //Console.WriteLine("Posição: "+tab);
            }catch(TabuleiroException e){
                System.Console.WriteLine(e.Message);
            }
           
        }
    }
}
