using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SW3
{
    public class Input
    {
        // TODO doc & might throws
        public string ReadLine(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadLine();
            }
        }

        // TODO doc & might throws
        public List<string> ReadWords(string path)
        {
            string line = this.ReadLine(path);
            return new List<string>(line.Split(' '));
        }
    }
}
