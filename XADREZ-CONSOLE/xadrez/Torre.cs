using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tabR, Cor corR) : base(tabR, corR) 
        {
 
        }

        public override string ToString()
        {
            return "T ";
        }
    }
}
