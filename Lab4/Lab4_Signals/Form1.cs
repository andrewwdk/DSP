using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab4_Signals.SignalTypes;

namespace Lab4_Signals
{
    public partial class Form1 : Form
    {
        const int N = 1024;

        public Form1()
        {
            InitializeComponent();
        }

        private bool IsCorrectDouble(string str, out double value)
        {
            bool result = true;

            if(double.TryParse(str, out value))
            {
                if (value >= 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }

            return result;
        }

        private void GenerateHarmonicButton_Click(object sender, EventArgs e)
        {
            double A, f, fi, dutyFactor;

            if(IsCorrectDouble(ATextBox.Text, out A) && IsCorrectDouble(fTextBox.Text, out f) && IsCorrectDouble(fiTextBox.Text, out fi)
                && IsCorrectDouble(dutyTextBox.Text, out dutyFactor))
            {
                SoundGenerator generator = new SoundGenerator();
                List<Signal> signalList = new List<Signal>();

                if (sinusoidRadioButton.Checked)
                {
                    signalList.Clear();
                    signalList.Add(new SinusoidSignal(A, f, fi));                
                }

                if (dutyCycleRadioButton.Checked)
                {
                    signalList.Clear();
                    signalList.Add(new DutyCycleSignal(A, f, fi, dutyFactor));
                }

                if (triangleRadioButton.Checked)
                {
                    signalList.Clear();
                    signalList.Add(new TriangleSignal(A, f, fi));
                }

                if (sawtoothedRadioButton.Checked)
                {
                    signalList.Clear();
                    signalList.Add(new SawtoothedSignal(A, f, fi));
                }

                if (noiseRadioButton.Checked)
                {
                    signalList.Clear();
                    signalList.Add(new NoiseSignal(A, f, fi));
                }

                DrawSignal(signalList);
                generator.WriteSignalToFile(signalList);
                generator.PlayCurrentFile();
            }
            else
            {
                MessageBox.Show("Please enter correct values!");
            }
        }

        private void DrawSignal(List<Signal> signalList)
        {
            double[] values = new double[N];

            for(var i = 0; i < N; i++)
            {
                double value = 0;

                foreach (Signal signal in signalList)
                {
                    value += signal.GetValue(i, N);
                }

                values[i] = value;
            }

            DrawSignalByValues(values);
        }

        private void DrawSignalByValues(double[] values)
        {
            signalChart.Series["Signal"].Points.Clear();

            for (var i = 0; i < N; i++)
            {
                signalChart.Series["Signal"].Points.AddXY(i, values[i]);
            }
        }

        private void PoliharmonicButton_Click(object sender, EventArgs e)
        {
            double A, f, fi, dutyFactor;

            if (IsCorrectDouble(ATextBox.Text, out A) && IsCorrectDouble(fTextBox.Text, out f) && IsCorrectDouble(fiTextBox.Text, out fi)
                && IsCorrectDouble(dutyTextBox.Text, out dutyFactor))
            {
                SoundGenerator generator = new SoundGenerator();
                List<Signal> signalList = new List<Signal>();
                Random rand = new Random();

                if (sinusoidRadioButton.Checked)
                {
                    signalList.Clear();
                    signalList.Add(new SinusoidSignal(A, f, fi));
                    signalList.Add(new SinusoidSignal(rand.NextDouble() * A, rand.NextDouble() * f, fi));
                    signalList.Add(new SinusoidSignal(rand.NextDouble() * A, rand.NextDouble() * f, fi));
                }

                if (dutyCycleRadioButton.Checked)
                {
                    signalList.Clear();
                    signalList.Add(new DutyCycleSignal(A, f, fi, dutyFactor));
                    signalList.Add(new DutyCycleSignal(A, f, fi, rand.NextDouble()));
                    signalList.Add(new DutyCycleSignal(A, f, fi, rand.NextDouble()));
                }

                if (triangleRadioButton.Checked)
                {
                    signalList.Clear();
                    signalList.Add(new TriangleSignal(A, f, fi));
                    signalList.Add(new TriangleSignal(rand.NextDouble() * A, rand.NextDouble() * f, fi));
                    signalList.Add(new TriangleSignal(rand.NextDouble() * A, rand.NextDouble() * f, fi));
                }

                if (sawtoothedRadioButton.Checked)
                {
                    signalList.Clear();
                    signalList.Add(new SawtoothedSignal(A, f, fi));
                    signalList.Add(new SawtoothedSignal(rand.NextDouble() * A, rand.NextDouble() * f, fi));
                    signalList.Add(new SawtoothedSignal(rand.NextDouble() * A, rand.NextDouble() * f, fi));
                }

                if (noiseRadioButton.Checked)
                {
                    signalList.Clear();
                    signalList.Add(new NoiseSignal(A, f, fi));
                    signalList.Add(new NoiseSignal(A, f, fi));
                    signalList.Add(new NoiseSignal(A, f, fi));
                }

                DrawSignal(signalList);
                generator.WriteSignalToFile(signalList);
                generator.PlayCurrentFile();
            }
            else
            {
                MessageBox.Show("Please enter correct values!");
            }
        }

        private void ModulationButton_Click(object sender, EventArgs e)
        {

        }
    }
}
