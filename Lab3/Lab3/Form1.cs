using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        const int N = 256;
        const int harmonicCount = 500;

        double B1;
        double B2;
        double[] initialXArray = new double[N];

        public Form1()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if(double.TryParse(B1TextBox.Text, out B1) && double.TryParse(B2TextBox.Text, out B2))
            {
                drawSignalButton.Enabled = true;
                slidingWindowButton.Enabled = true;
                parabolaButton.Enabled = true;
                medianFilteringButton.Enabled = true;

                for (int i = 0; i < N; i++)
                {
                    initialXArray[i] = Xi(i);
                }
            }
            else
            {
                MessageBox.Show("B1 and B2 should have double values.");
            }
        }

        private double Xi(int i)
        {
            double x = B1 * Math.Sin(2 * Math.PI * i / N);
            Random rand = new Random();
            double power;

            for(int j = 50; j <= 70; j++)
            {
                power = rand.Next(0, 2);
                x += Math.Pow(-1, power) * B2 * Math.Sin(2 * Math.PI * i * j / N);
            }

            return x;
        }

        private void DrawAmplitudeAndPhase(double[] xArray)
        {
            amplitudeChart.Series["Amplitude"].Points.Clear();
            phaseChart.Series["Phase"].Points.Clear();
            double Ac, As;

            for(int j = 0; j < harmonicCount; j++)
            {
                As = 0;
                Ac = 0;

                for(int i = 0; i < N; i++)
                {
                    Ac += xArray[i] * Math.Cos(2 * Math.PI * i * j / N);
                    As += xArray[i] * Math.Sin(2 * Math.PI * i * j / N);
                }

                Ac = 2 * Ac / N;
                As = 2 * As / N;

                amplitudeChart.Series["Amplitude"].Points.AddXY(j, Math.Sqrt(Ac * Ac + As * As));
                phaseChart.Series["Phase"].Points.AddXY(j, Math.Atan(As / Ac));
                //phaseChart.Series["Phase"].Points.AddXY(j, Math.Atan2(Ac, As));
            }
        }

        private void DrawSignalButton_Click(object sender, EventArgs e)
        {
            signalChart.Series["Signal"].Points.Clear();

            for(int i = 0; i < N; i++)
            {
                signalChart.Series["Signal"].Points.AddXY(i, initialXArray[i]);
            }

            DrawAmplitudeAndPhase(initialXArray);
        }

        private void SlidingWindowButton_Click(object sender, EventArgs e)
        {
            signalChart.Series["Signal"].Points.Clear();
            double[] xArray = new double[N];
            int K = 3;
            int m = (K - 1) / 2;

            for (int i = 0; i < m; i++)
            {
                xArray[i] = initialXArray[i];
            }

            for (int i = m; i < N - m; i++)
            {
                double sum = 0;

                for (int j = i - m; j <= i + m; j++)
                {
                    sum += initialXArray[j];
                }

                xArray[i] = sum / K;
            }

            for (int i = N - m; i < N; i++)
            {
                xArray[i] = initialXArray[i];
            }

            for (int i = 0; i < N; i++)
            {
                signalChart.Series["Signal"].Points.AddXY(i, xArray[i]);
            }

            DrawAmplitudeAndPhase(xArray);
        }

        private void ParabolaButton_Click(object sender, EventArgs e)
        {
            signalChart.Series["Signal"].Points.Clear();
            double[] xArray = new double[N];

            for (int i = 0; i < 3; i++)
            {
                xArray[i] = initialXArray[i];
            }

            for (int i = 3; i < N - 3; i++)
            {
                double q1 = initialXArray[i];
                
                xArray[i] = (5 * initialXArray[i-3] - 30 * initialXArray[i-2] + 75 * initialXArray[i-1] + 131 * initialXArray[i] +
                    75 * initialXArray[i+1] - 30 * initialXArray[i+2] + 5 * initialXArray[i+3]) / 231;
                double q2 = xArray[i];
            }

            for (int i = N - 3; i < N; i++)
            {
                xArray[i] = initialXArray[i];
            }

            for (int i = 0; i < N; i++)
            {
                signalChart.Series["Signal"].Points.AddXY(i, xArray[i]);
            }

            DrawAmplitudeAndPhase(xArray);
        }

        private void MedianFilteringButton_Click(object sender, EventArgs e)
        {
            signalChart.Series["Signal"].Points.Clear();
            double[] xArray = new double[N];
            int K = 7;
            int m = (K - 1) / 2;

            for (int i = 0; i < m; i++)
            {
                xArray[i] = initialXArray[i];
            }

            for (int i = m; i < N - m; i++)
            {
                List<double> list = new List<double>();
                for(int j = i - m; j <= i + m; j++)
                {
                    list.Add(initialXArray[j]);
                }
                list.Sort();
                xArray[i] = list[m];
            }

            for (int i = N - m; i < N; i++)
            {
                xArray[i] = initialXArray[i];
            }

            for (int i = 0; i < N; i++)
            {
                signalChart.Series["Signal"].Points.AddXY(i, xArray[i]);
            }

            DrawAmplitudeAndPhase(xArray);
        }
    }
}
