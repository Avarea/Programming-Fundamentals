using System;
using System.Collections.Generic;
using System.Linq;

namespace NoteStatistic
{
    class Program
    {
        static void Main()
        {
            List<double> frequencies = Console.ReadLine()?.Split(' ').Select(double.Parse).ToList();
            List<string> notes = new List<string>();

            double naturalsSum = 0.0;
            double sharpsSum = 0.0;
            string neutrals = "";
            string sharps = "";

            for (int cnt = 0; cnt < frequencies.Count; cnt++)
            {
                switch (frequencies[cnt])
                {
                    case 261.63:
                        notes.Add("C");
                        naturalsSum += frequencies[cnt];
                        break;
                    case 277.18:
                        notes.Add("C#");
                        sharpsSum += frequencies[cnt];
                        break;
                    case 293.66:
                        notes.Add("D");
                        naturalsSum += frequencies[cnt];
                        break;
                    case 311.13:
                        notes.Add("D#");
                        sharpsSum += frequencies[cnt];
                        break;
                    case 329.63:
                        notes.Add("E");
                        naturalsSum += frequencies[cnt];
                        break;
                    case 349.23:
                        notes.Add("F");
                        naturalsSum += frequencies[cnt];
                        break;
                    case 369.99:
                        notes.Add("F#");
                        sharpsSum += frequencies[cnt];
                        break;
                    case 392.00:
                        notes.Add("G");
                        naturalsSum += frequencies[cnt];
                        break;
                    case 415.30:
                        notes.Add("G#");
                        sharpsSum += frequencies[cnt];
                        break;
                    case 440.00:
                        notes.Add("A");
                        naturalsSum += frequencies[cnt];
                        break;
                    case 466.16:
                        notes.Add("A#");
                        sharpsSum += frequencies[cnt];
                        break;
                    case 493.88:
                        notes.Add("B");
                        naturalsSum += frequencies[cnt];
                        break;
                }
            }
            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].Contains("#"))
                {
                    sharps += notes[i] + ", ";
                }
                else
                {
                    neutrals += notes[i] + ", ";
                }
            }
            Console.WriteLine("Notes: " + string.Join(" ", notes));
            Console.WriteLine("Naturals: " + neutrals.TrimEnd().Trim(','));
            Console.WriteLine("Sharps: " + sharps.TrimEnd().Trim(','));
            Console.WriteLine("Naturals sum: " + naturalsSum);
            Console.WriteLine("Sharps sum: " + sharpsSum);
        }
    }
}
