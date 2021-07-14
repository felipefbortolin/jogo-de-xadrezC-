using System;
using tabuleiro;
using xadrez;

namespace XadrezC_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    try
                    {
                        Console.Clear();
                        
                        Tela.ImprimirPartida(partida);

                        System.Console.Write("\nOrigem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

                        System.Console.Write("\nDestino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeDestino(origem, destino);
                        partida.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        System.Console.WriteLine(e.Message);
                        System.Console.ReadLine();
                    }
                }

                Tela.ImprimirTabuleiro(partida.Tab);
                //Console.WriteLine("Posição: "+tab);
            }
            catch (TabuleiroException e)
            {
                System.Console.WriteLine(e.Message);
            }

        }
    }
}
