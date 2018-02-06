using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Posicao
    {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int linhaC, int colunaC)
        {
            this.linha = linhaC;
            this.coluna = colunaC;
        }

        public override string ToString()
        {
            return linha
                + ", "
                + coluna;
        }
    }
}
