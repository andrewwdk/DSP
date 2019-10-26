using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Lab4_Signals.SignalTypes;

namespace Lab4_Signals
{
    public class SoundGenerator
    {
        const int RIFF = 0x46464952;
        const int WAVE = 0x45564157;
        const int formatChunkSize = 16;
        const int headerSize = 8;
        const int format = 0x20746D66;
        const short formatType = 1;
        const short tracks = 1;
        const int samplesPerSecond = 44100;
        const short bitsPerSample = 16;
        const short frameSize = (short)(tracks * ((bitsPerSample + 7) / 8));
        const int bytesPerSecond = samplesPerSecond * frameSize;
        const int waveSize = 4;
        const int data = 0x61746164;
        const int samples = 88200 /** 4*/;
        const int dataChunkSize = samples * frameSize;
        const int fileSize = waveSize + headerSize + formatChunkSize + headerSize + dataChunkSize;

        public void WriteSignalByValuesToFile(double[] values)
        {
            FileStream stream = new FileStream("test.wav", FileMode.Create);
            BinaryWriter writer = new BinaryWriter(stream);

            writer.Write(RIFF);
            writer.Write(fileSize);
            writer.Write(WAVE);
            writer.Write(format);
            writer.Write(formatChunkSize);
            writer.Write(formatType);
            writer.Write(tracks);
            writer.Write(samplesPerSecond);
            writer.Write(bytesPerSecond);
            writer.Write(frameSize);
            writer.Write(bitsPerSample);
            writer.Write(data);
            writer.Write(dataChunkSize);
            
            for (int i = 0; i < samples; i++)
            {
                writer.Write(values[i]);
            }

            writer.Close();
            stream.Close();
        }

        public void WriteSignalToFile(List<Signal> signalList)
        {
            double[] values =  new double[samples];
            
            for (int i = 0; i < samples; i++)
            {
                double value = 0;

                foreach (Signal signal in signalList)
                {
                    value += signal.GetValue(i, samplesPerSecond);
                }

                values[i] = value;
            }

            WriteSignalByValuesToFile(values);
        }

        public void PlayCurrentFile()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "test.wav";
            player.Load();
            player.Play();
        }
    }
}
