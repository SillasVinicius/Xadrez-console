using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhasC, int colunasC)
        {
            this.linhas = linhasC;
            this.colunas = colunasC;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linhasP, int colunasP)
        {
            return pecas[linhasP, colunasP];
        }

        public void colocarPeca(Peca p, Posicao pos) 
        {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
    }
}
