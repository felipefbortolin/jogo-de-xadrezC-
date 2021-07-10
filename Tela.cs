using System;
using tabuleiro;
using tabuleiro.Enums;

namespace XadrezC_
{
    class Tela
    {
       public static void ImprimirTabuleiro(Tabuleiro tab){
           for (int i = 0; i < tab.Linhas; i++)
           {
               System.Console.Write(8 - i + " ");
               for (int j = 0; j < tab.Colunas; j++)
               {
                   if (tab.Peca(i,j) == null)
                   {
                       System.Console.Write("- ");
                   }else{
                       Tela.ImprimirPeca(tab.Peca(i,j));
                   System.Console.Write(" ");
                   }
               }
               System.Console.WriteLine();
           }
           System.Console.WriteLine("  a b c d e f g h");
       }

       public static void ImprimirPeca(Peca peca){
            if (peca.Cor == Cor.Branca)
            {
                System.Console.Write(peca);
            }
            else{
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.Write(peca);
                Console.ForegroundColor = aux;
            }

        }
    }
}
