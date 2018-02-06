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
    }
}
