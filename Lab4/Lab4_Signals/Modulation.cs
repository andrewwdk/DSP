using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4_Signals.SignalTypes;

namespace Lab4_Signals
{
    public class Modulation
    {
        public double[] GetAmplitudeModulation(Signal mainSignal, Signal modulationSignal, int samples)
        {
            double[] values = new double[samples];

            for(int i = 0; i < samples; i++)
            {
                var modulationAmplitude = Math.Abs(modulationSignal.GetValue(i, samples));
                values[i] = modulationAmplitude * mainSignal.GetValue(i, samples) / mainSignal.A;
            }

            return values;
        }

        public double[] GetFrequencyModulation(Signal mainSignal, Signal modulationSignal, int samples)
        {
            double[] values = new double[samples];
            double fi = 0;
            var mainSignalF = mainSignal.F;

            for (int i = 0; i < samples; i++)
            {
                //var lfo = modulationSignal.GetValue(i, samples);
                //fi = 2 * Math.PI * mainSignalF * (lfo) / samples;
                //mainSignal.F = 0;
                //mainSignal.Fi = fi;

                //values[i] = mainSignal.GetValue(i, samples);
                mainSignal.F = modulationSignal.F;
                values[i] = mainSignal.GetValue(i, samples);
            }

            return values;
        }
    }
}
