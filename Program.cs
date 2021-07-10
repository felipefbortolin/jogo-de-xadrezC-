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
            /*try{
            Tabuleiro tab = new Tabuleiro(8,8);

            tab.ColocarPeca(new Torre(tab,Cor.Preta),new Posicao(0,0));
            tab.ColocarPeca(new Torre(tab,Cor.Preta),new Posicao(1,3));
            tab.ColocarPeca(new Rei(tab,Cor.Preta),new Posicao(0,4));

            Tela.ImprimirTabuleiro(tab);
            //Console.WriteLine("Posição: "+tab);
            }catch(TabuleiroException e){
                System.Console.WriteLine(e.Message);
            }*/
            PosicaoXadrez pos = new PosicaoXadrez('c',7);
            System.Console.WriteLine(pos);
            System.Console.WriteLine(pos.ToPosicao());
        }
    }
}
