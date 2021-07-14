using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;

namespace XadrezC_
{
    class Tela
    {
        public static void ImprimirPartida(PartidaDeXadrez partida)
        {
            ImprimirTabuleiro(partida.Tab);
            ImprimirPecasCapturadas(partida);
            System.Console.WriteLine("Turno: " + partida.Turno);
            if (!partida.Terminada)
            {
            System.Console.WriteLine("Aguarnando jogada: " + partida.JogadorAtual);
            if (partida.Xeque)
            {
                System.Console.WriteLine("XEQUE!");
            }   
            }else{
                System.Console.WriteLine("XEQUEMATE!");
                System.Console.WriteLine("Vencedor: "+partida.JogadorAtual);
                Console.ReadLine();
            }
        }

        public static void ImprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            System.Console.WriteLine("\nPeças capturadas:");
            System.Console.Write("Brancas: ");
            ImprimirConjunto(partida.PecasCapturadas(Cor.Branca));
            System.Console.Write("\nPretas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            ImprimirConjunto(partida.PecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
            System.Console.WriteLine();
        }

        public static void ImprimirConjunto(HashSet<Peca> conjunto)
        {
            System.Console.Write("[");
            foreach (Peca x in conjunto)
            {
                System.Console.Write(x + " ");
            }
            System.Console.Write("]");
        }

        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                System.Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    Tela.ImprimirPeca(tab.Peca(i, j));
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.Linhas; i++)
            {
                System.Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (posicoesPossiveis[i, j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    Tela.ImprimirPeca(tab.Peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }

        public static void ImprimirPeca(Peca peca)
        {

            if (peca == null)
            {
                System.Console.Write("- ");
            }
            else
            {


                if (peca.Cor == Cor.Branca)
                {
                    System.Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    System.Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                System.Console.Write(" ");
            }

        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
    }
}
