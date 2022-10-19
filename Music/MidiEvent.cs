using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    class MidiEvent
    {
        // the byetes that are sent as MIDI data
        private byte[] buffer = new byte[3];

        // there are 16 channels t choose from. Channel 9 is perussion
        private int Channel;

        /// <summary>
        /// Send MIDI data
        /// </summary>
        public void Send()
        {
            Console.WriteLine($"Not implemented yet: sneding midi data");
        }
    }
}
