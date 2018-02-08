using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tabC, Cor corC)
        {
            this.posicao = null;
            this.tab = tabC;
            this.cor = corC;
            qteMovimentos = 0;
        }

        public void incrementarQteMovimentos() 
        {
            qteMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
