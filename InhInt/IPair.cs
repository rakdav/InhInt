using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhInt
{
    internal interface IPair
    {
        double A { get; set; }
        double B { get; set; }
        IPair Add(IPair pair);
        IPair Sub(IPair pair);
        IPair Mult(IPair pair);
        IPair Div(IPair pair);
        bool Equ(IPair pair);
        IPair Conj();
    }
}
