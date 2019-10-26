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
        const int samples = 88200;

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
            double A, f, fi, dutyFactor, AMod, fMod, fiMod, dutyMod;
            Signal mainSignal = null, modalationSignal = null;
            Modulation modulation = new Modulation();
            SoundGenerator generator = new SoundGenerator();

            if (IsCorrectDouble(ATextBox.Text, out A) && IsCorrectDouble(fTextBox.Text, out f) && IsCorrectDouble(fiTextBox.Text, out fi)
                && IsCorrectDouble(dutyTextBox.Text, out dutyFactor) && IsCorrectDouble(AModulationTextBox.Text, out AMod) && IsCorrectDouble(fModulationTextBox.Text, out fMod) &&
                IsCorrectDouble(fiModulationTextBox.Text, out fiMod) && IsCorrectDouble(dutyModulationTextBox.Text, out dutyMod))
            {
                if (sinusoidRadioButton.Checked)
                {
                    mainSignal = new SinusoidSignal(A, f, fi);
                }

                if (dutyCycleRadioButton.Checked)
                {
                    mainSignal = new DutyCycleSignal(A, f, fi, dutyFactor);
                }

                if (triangleRadioButton.Checked)
                {
                    mainSignal = new TriangleSignal(A, f, fi);
                }

                if (sawtoothedRadioButton.Checked)
                {
                    mainSignal = new SawtoothedSignal(A, f, fi);
                }

                if (noiseRadioButton.Checked)
                {
                    mainSignal = new NoiseSignal(A, f, fi);
                }

                if (SinusoidModulationRadioButton.Checked)
                {
                    modalationSignal = new SinusoidSignal(AMod, fMod, fiMod);
                }

                if (DutyCycleModulationRadioButton.Checked)
                {
                    modalationSignal = new DutyCycleSignal(AMod, fMod, fiMod, dutyMod);
                }

                if (triangleModulationRadioButton.Checked)
                {
                    modalationSignal = new TriangleSignal(AMod, fMod, fiMod);
                }

                if (sawtoothedModulationRadioButton.Checked)
                {
                    modalationSignal = new SawtoothedSignal(AMod, fMod, fiMod);
                }

                if (noiseModulationRadioButton.Checked)
                {
                    modalationSignal = new NoiseSignal(AMod, fMod, fiMod);
                }

                if (AmplitudeModulationRadioButton.Checked)
                {
                    DrawSignalByValues(modulation.GetAmplitudeModulation(mainSignal, modalationSignal, N));
                    generator.WriteSignalByValuesToFile(modulation.GetAmplitudeModulation(mainSignal, modalationSignal, samples));    
                }
                else
                {
                    DrawSignalByValues(modulation.GetFrequencyModulation(mainSignal, modalationSignal, N));
                    generator.WriteSignalByValuesToFile(modulation.GetFrequencyModulation(mainSignal, modalationSignal, samples));
                }

                generator.PlayCurrentFile();
            }
        }
    }
}
