using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhInt
{
    internal class Complex:IPair
    {
        public double A { get; set; }
        public double B { get; set; }

        public Complex(double a, double b)
        {
            A = a;
            B = b;
        }

        public IPair Add(IPair pair)
        {
            return new Complex(this.A + pair.A, this.B + pair.B);
        }

        public IPair Conj()
        {
            return new Complex(this.A,-this.B);
        }

        public IPair Div(IPair pair)
        {
            return new Complex((this.A * pair.A + this.B * pair.B) / (pair.A * pair.A + pair.B * pair.B),
                (this.A * pair.B + this.B * pair.A) / (pair.A * pair.A + pair.B * pair.B));
        }

        public bool Equ(IPair pair)
        {
            return (this.A == pair.A) && (this.B == pair.B);
        }

        public IPair Mult(IPair pair)
        {
            return new Complex(this.A * pair.A - this.B * pair.B, this.A * pair.B + pair.A * this.B);
        }

        public IPair Sub(IPair pair)
        {
            return new Complex(this.A - pair.A, this.B - pair.B);
        }

        public override string? ToString()
        {
            if (B > 0)
                return A + "+" + B + "i";
            else if (B < 0)
                return A + "-" + Math.Abs(B) + "i";
            return A.ToString();
        }
    }
}
