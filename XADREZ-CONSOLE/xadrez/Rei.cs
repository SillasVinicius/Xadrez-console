using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tabR, Cor corR) : base(tabR, corR) 
        {
 
        }

        public override string ToString()
        {
            return "R ";
        }
        
    }
}
