using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Signals.SignalTypes
{
    public class TriangleSignal : Signal
    {
        public TriangleSignal(double A, double f, double fi)
            : base(A, f, fi)
        {
        }
        public override double GetValue(int x, int N)
        {
            return A * 2 * Math.Asin(Math.Sin(2 * Math.PI * F * x / N + Fi)) / Math.PI;
        }
    }
}
