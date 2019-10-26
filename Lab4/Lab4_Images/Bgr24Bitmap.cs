using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Lab4_Images
{
    public class Bgr24Bitmap : IEnumerable<Vector3>
    {
        private int BackBuffer { get; set; }
        private int BackBufferStride { get; set; }
        private int BytesPerPixel { get; set; }

        public int PixelWidth { get; private set; }
        public int PixelHeight { get; private set; }
        public WriteableBitmap Source { get; private set; }

        public Bgr24Bitmap(WriteableBitmap source)
        {
            if (source.Format != PixelFormats.Bgr24)
                source = new WriteableBitmap(new FormatConvertedBitmap(
                    source, PixelFormats.Bgr24, null, 0));
            Source = source;
            PixelWidth = Source.PixelWidth;
            PixelHeight = Source.PixelHeight;
            BackBuffer = Source.BackBuffer.ToInt32();
            BackBufferStride = Source.BackBufferStride;
            BytesPerPixel = Source.Format.BitsPerPixel / 8;
        }

        private unsafe byte* GetAddress(int x, int y)
        {
            return (byte*)(BackBuffer + y * BackBufferStride + x * BytesPerPixel);
        }

        public unsafe Vector3 this[int x, int y]
        {
            get
            {
                byte* address = GetAddress(x, y);
                return new Vector3(address[0], address[1], address[2]);
            }
            set
            {
                byte* address = GetAddress(x, y);
                address[0] = Convert.ToByte(value.X);
                address[1] = Convert.ToByte(value.Y);
                address[2] = Convert.ToByte(value.Z);
            }
        }

        public IEnumerator<Vector3> GetEnumerator()
        {
            for (int y = 0; y < PixelHeight; y++)
            {
                for (int x = 0; x < PixelWidth; x++)
                {
                    yield return this[x, y];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}