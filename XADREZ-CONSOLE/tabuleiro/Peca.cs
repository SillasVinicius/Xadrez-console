using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentacao { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicaoC, Tabuleiro tabC, Cor corC)
        {
            this.posicao = posicaoC;
            this.tab = tabC;
            this.cor = corC;
            qteMovimentacao = 0;
        }
    }
}
