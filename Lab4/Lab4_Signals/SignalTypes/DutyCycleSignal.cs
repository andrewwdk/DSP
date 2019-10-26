using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Signals.SignalTypes
{
    class DutyCycleSignal : Signal
    {
        public double DutyFactor { get; protected set; }
        public DutyCycleSignal(double A, double f, double fi, double dutyFactor)
            : base(A, f, fi)
        {
            this.DutyFactor = dutyFactor;
        }

        public override double GetValue(int x, int N)
        {
            int coef = (Math.Sin(2 * Math.PI * F * x/N + Fi) + 1 >= 2 - 2 * DutyFactor) ? 1 : 0;
            return A * coef;
        }
    }
}
