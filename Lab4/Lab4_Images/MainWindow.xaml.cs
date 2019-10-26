using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace Lab4_Images
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WriteableBitmap initialWriteableBitmap;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.InitialDirectory = @"D:\учёба\цос";
            opd.Filter = "obj files (*.jpg) | *.jpg";

            if (opd.ShowDialog() == true)
            {
                string filePath = opd.FileName;
                BitmapImage img = new BitmapImage(new Uri(filePath, UriKind.Relative));
                img.CreateOptions = BitmapCreateOptions.None;
                initialWriteableBitmap = new WriteableBitmap(img);
                initialImage.Source = initialWriteableBitmap;   
            }
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            int width = (int)initialWriteableBitmap.Width;
            int height = (int)initialWriteableBitmap.Height;
            Bgr24Bitmap finalBitmap = new Bgr24Bitmap(new WriteableBitmap(width, height, 96, 96, PixelFormats.Bgra32, null));
            Bgr24Bitmap initialBitmap = new Bgr24Bitmap(initialWriteableBitmap);
            List<Vector3> list = new List<Vector3>();
            int windowSize = Convert.ToInt32(windowSizeTextBox.Text);

            for (int y = 0; y < height; y++)
            {
                for(int x = 0; x < width; x++)
                {
                    if (x >= windowSize / 2 && y >= windowSize / 2 && x <= width - windowSize / 2 - 1 && y <= height - windowSize / 2 - 1)
                    {
                        list.Clear();

                        for (int y1 = y - windowSize / 2; y1 <= y + windowSize / 2; y1++)
                        {
                            for (int x1 = x - windowSize / 2; x1 <= x + windowSize / 2; x1++)
                            {
                                list.Add(initialBitmap[x1, y1]);
                            }
                        }

                        finalBitmap[x, y] = GetAverage(list);
                    }
                    else
                    {
                        finalBitmap[x, y] = initialBitmap[x, y];
                    }
                }
            }

            filteredImage.Source = finalBitmap.Source;
        }

        private Vector3 GetAverage(List<Vector3> list)
        {
            int sumR = 0;
            int sumG = 0;
            int sumB = 0;

            foreach(Vector3 vector in list)
            {
                sumR += (int)vector.X;
                sumG += (int)vector.Y;
                sumB += (int)vector.Z;
            }

            float R = (float)Math.Round((decimal)(sumR / list.Count));
            float G = (float)Math.Round((decimal)(sumG / list.Count));
            float B = (float)Math.Round((decimal)(sumB / list.Count));
            return new Vector3(R, G, B);
        }
    }
}
