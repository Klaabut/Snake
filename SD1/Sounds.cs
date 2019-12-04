using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SD1
{
    class Sounds
    {
        public static void PlayBackgroundMusic()
        {
            using (var waveOut = new WaveOutEvent())
            using (var wavReader = new WaveFileReader(@"c:\users\karl\desktop\VS\Snake\MGSBM.wav"))
            {
                waveOut.Init(wavReader);
                waveOut.Play();
                Thread.Sleep(14100);
            }


        }

        public static void DeathSound()
        {
            using (var waveOut = new WaveOutEvent())
            using (var wavReader = new WaveFileReader(@"c:\users\karl\desktop\VS\Snake\DS.wav"))
            {
                waveOut.Init(wavReader);
                waveOut.Play();
                Thread.Sleep(9000);
            }
        }

        public static void GainSound()
        {
            using (var waveOut = new WaveOutEvent())
            using (var wavReader = new WaveFileReader(@"c:\users\karl\desktop\VS\Snake\GS.wav"))
            {
                waveOut.Init(wavReader);
                waveOut.Play();
                Thread.Sleep(750);
            }
        }
    }
}
