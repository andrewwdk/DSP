using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Signals.SignalTypes
{
    public abstract class Signal
    {
        public double A { get; protected set; }
        public double F { get; set; }
        public double Fi { get; set; }

        public Signal(double A, double f, double fi)
        {
            this.A = A;
            this.F = f;
            this.Fi = fi;
        }

        public abstract double GetValue(int x, int N);
    }
}
