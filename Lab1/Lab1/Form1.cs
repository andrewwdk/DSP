using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        const int pixelsInYUnit = 20;
        const int initialX = 50;
        readonly int initialY;
        const int N = 1024;

        Bitmap bm;

        public Form1()
        {
            InitializeComponent();
            initialY = backgroundPictureBox.Height / 2;
        }

        private void DrawGraphics(Point[] points, Color color)
        {
            DrawAxis(bm);

            foreach (Point point in points)
            {
                if (point.X < backgroundPictureBox.Width)
                {
                    bm.SetPixel(point.X, point.Y, color);
                }
            }

            backgroundPictureBox.Image = bm;
        }

        private void DrawAxis(Bitmap bm)
        {
            var graphics = Graphics.FromImage(bm);

            graphics.DrawLine(Pens.Black, initialX, initialY, backgroundPictureBox.Width, initialY);
            graphics.DrawLine(Pens.Black, initialX, initialY - 250, initialX, initialY + 250);

            for(int i = 1; i < 10; i++)
            {
                graphics.DrawLine(Pens.Black, initialX + 100 * i, initialY - 5, initialX + 100 * i, initialY + 5);
                graphics.DrawString((i*100).ToString(), new Font("Arial", 12), new SolidBrush(Color.Black), initialX + 96 * i, initialY + 10);
            }

            for (int i = 12; i > -13; i--)
            {
                graphics.DrawLine(Pens.Black, initialX + 5, initialY + i * pixelsInYUnit, initialX - 5, initialY + i * pixelsInYUnit);
                if (i % 2 == 0)
                {
                    graphics.DrawString((-1 * i).ToString(), new Font("Arial", 12), new SolidBrush(Color.Black), initialX - 35, initialY + i * pixelsInYUnit - 8);
                }
            }
        }

        private void DecideColor(int i, out Color color)
        {
            switch (i)
            {
                case 0:
                    color = Color.Red;
                    break;
                case 1:
                    color = Color.Blue;
                    break;
                case 2:
                    color = Color.Green;
                    break;
                case 3:
                    color = Color.Yellow;
                    break;
                case 4:
                    color = Color.Orange;
                    break;
                default:
                    color = Color.Black;
                    break;
            }
        }

        private void Task1aButton_Click(object sender, EventArgs e)
        {
            var A = 7;
            var f = 5;
            var fiArray = new double[]{ Math.PI, 0, Math.PI / 3, Math.PI / 6, Math.PI / 2 };
            var pointsList = new List<Point>();
            Color color;

            bm = new Bitmap(backgroundPictureBox.Width, backgroundPictureBox.Height);

            for (int i = 0; i < 5; i++)
            {
                for(int n = 0; n < N; n++)
                {
                    var y = A * Math.Sin(2*Math.PI*f*n/N + fiArray[i]);
                    pointsList.Add(new Point(initialX + n, (int)Math.Round(initialY - y * pixelsInYUnit)));
                }

                DecideColor(i, out color);

                DrawGraphics(pointsList.ToArray(), color);
                pointsList.Clear();
            }
        }

        private void Task1bButton_Click(object sender, EventArgs e)
        {
            var A = 5;
            var fi = 3*Math.PI/4;
            var fArray = new double[] { 1, 5, 11, 6, 3};
            var pointsList = new List<Point>();
            Color color;

            bm = new Bitmap(backgroundPictureBox.Width, backgroundPictureBox.Height);

            for (int i = 0; i < 5; i++)
            {
                for (int n = 0; n < N; n++)
                {
                    var y = A * Math.Sin(2 * Math.PI * fArray[i] * n / N + fi);
                    pointsList.Add(new Point(initialX + n, (int)Math.Round(initialY - y * pixelsInYUnit)));
                }

                DecideColor(i, out color);

                DrawGraphics(pointsList.ToArray(), color);
                pointsList.Clear();
            }
        }

        private void Task1cButton_Click(object sender, EventArgs e)
        {
            var AArray = new double[] { 1, 2, 11, 4, 2};
            var fi = 3 * Math.PI / 4;
            var f = 3;
            var pointsList = new List<Point>();
            Color color;

            bm = new Bitmap(backgroundPictureBox.Width, backgroundPictureBox.Height);

            for (int i = 0; i < 5; i++)
            {
                for (int n = 0; n < N; n++)
                {
                    var y = AArray[i] * Math.Sin(2 * Math.PI * f * n / N + fi);
                    pointsList.Add(new Point(initialX + n, (int)Math.Round(initialY - y * pixelsInYUnit)));
                }

                DecideColor(i, out color);

                DrawGraphics(pointsList.ToArray(), color);
                pointsList.Clear();
            }
        }

        private void Task2Button_Click(object sender, EventArgs e)
        {
            var A = 9;
            var fiArray = new double[] { Math.PI/2, 0, Math.PI/4, Math.PI/3, Math.PI/6 };
            var fArray = new double[] { 1, 2, 3, 4, 5 };
            //var fArray = new double[] { 20, 30, 20, 30, 20 };
            var pointsList = new List<Point>();

            bm = new Bitmap(backgroundPictureBox.Width, backgroundPictureBox.Height);

            for (int n = 0; n < N; n++)
            {
                double sum = 0;
                for (int i = 0; i < 5; i++)
                {
                    sum += A * Math.Sin(2 * Math.PI * fArray[i] * n / N + fiArray[i]);
                }

                pointsList.Add(new Point(initialX + n, (int)Math.Round(initialY - sum * pixelsInYUnit/3))); //!!! 3 scale 
            }

            DrawGraphics(pointsList.ToArray(), Color.Red);
        }

        private void Task2bButton_Click(object sender, EventArgs e)
        {
            var A = 9;
            var fiArray = new double[] { Math.PI / 2, 0, Math.PI / 4, Math.PI / 3, Math.PI / 6 };
            var fArray = new double[] { 1, 2, 3, 4, 5 };
            var pointsList = new List<Point>();
            Color color;

            bm = new Bitmap(backgroundPictureBox.Width, backgroundPictureBox.Height);

            for (int j = 0; j < 5; j++)
            {
                for (int n = 0; n < N; n++)
                {
                    double sum = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        sum += A * Math.Sin(2 * Math.PI * fArray[i] * n / N + fiArray[i] + j * Math.PI/10); 
                    }

                    pointsList.Add(new Point(initialX + n, (int)Math.Round(initialY - sum * pixelsInYUnit / 3))); //!!! 3 scale 
                }

                DecideColor(j, out color);
                DrawGraphics(pointsList.ToArray(), color);
                pointsList.Clear();
            }
        }

        private void Task4Button_Click(object sender, EventArgs e)
        {
            var pointsList = new List<Point>();
            Func<double, double> funcAmpl = (x) => -5 * x + 50;
            Func<double, double> funcPhase = (x) => -1 * x + 5;
            Func<double, double> funcFreq = (x) => -20 * x + 30;

            //Func<double, double> funcAmpl = (x) => 5 + 0.15 * 5 * x;
            //Func<double, double> funcPhase = (x) => Math.PI / 6 + 0.15 * Math.PI / 6 * x;
            //Func<double, double> funcFreq = (x) => 25 + 25 * 0.15 * x;

            bm = new Bitmap(backgroundPictureBox.Width, backgroundPictureBox.Height);

            for (int i = 0; i < N; i++)
            {
                var x = i / (double)N;
                var ampl = funcAmpl(x);
                var phase = funcPhase(x);
                var freq = funcFreq(x);

                var y = ampl * Math.Sin(2 * Math.PI * freq * x + phase);
                pointsList.Add(new Point(initialX + i, (int)Math.Round(initialY - y * pixelsInYUnit / 5))); //!!! 5 scale 
            }

            DrawGraphics(pointsList.ToArray(), Color.Red);
        }
    }
}
