using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Music
{
    class Music
    {
        List<Note> Notes = new List<Note>();
        public void Play()
        {
            Console.WriteLine($"Playing...");
            foreach (Note n in Notes)
            {
                n.Play();
            }
        }

        public Music(string Filename)
        {
            Console.WriteLine($"Loading file from {Filename}");

            // load from the file
            string fileContents = File.ReadAllText(Filename);

            // remove the comments
            fileContents = Regex.Replace(fileContents, @"\/\/.*", "");

            int octave = 4;
            // extract the notes
            foreach(Match m in Regex.Matches(fileContents, @"([A-G])([b#])*(\d)*(:(\d))*"))
            {
                // get the note name
                string note = m.Groups[1].Value;

                // get the octave
                if (m.Groups[3].Value.Length > 0)
                {
                    octave = int.Parse(m.Groups[3].Value);
                }


                // get flat or sharp
                if (m.Groups[2].Value == "b")
                {
                    Console.WriteLine("Flat!");
                }

                if (m.Groups[2].Value == "#")
                {
                    Console.WriteLine("Sharp!");
                }

                Console.WriteLine($"Note: {note} Octave: {octave}");
            }
            Console.WriteLine(fileContents);

            Console.ReadLine();
        }

    }
}
