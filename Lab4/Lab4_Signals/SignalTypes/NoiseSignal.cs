using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Signals.SignalTypes
{
    public class NoiseSignal : Signal
    {
        private static readonly Random Random = new Random();
        private const double MinValue = -1;
        private const double MaxValue = 1;
        public NoiseSignal(double A, double f, double fi)
            : base(A, f, fi)
        {
        }
        public override double GetValue(int x, int N)
        {
            return Random.NextDouble() * (MaxValue - MinValue) + MinValue;
        }
    }
}
