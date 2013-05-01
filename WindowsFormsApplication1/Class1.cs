using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.Mixer;

namespace WindowsFormsApplication1
{
    class Record
    {

        WaveIn waveIn;
        private WaveFileWriter writer;


        public Record()
        {
            waveIn = new WaveIn();
            waveIn.WaveFormat = new WaveFormat(44100, 1);

            writer = new WaveFileWriter("C:\test.wav", waveIn.WaveFormat);

            waveIn.DataAvailable += OnDataAvailable;
            waveIn.RecordingStopped += OnRecordingStopped;
            waveIn.StartRecording();

        }



    }
}
