using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace SW3
{
    public class Input
    {
        private List<string> content;

        // todo doc & might throws
        public Input(string path)
        {
            this.content = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    this.content.Add(line);
                }
            }
        }

        // forward the number of item of the private list
        public int GetLineCount()
        {
            return this.content.Count;
        }

        // TODO doc
        public string GetLine(int nbLine)
        {
            return this.content[nbLine];
        }

        // TODO doc
        public List<string> GetWords(int nbLine)
        {
            string line = this.GetLine(nbLine);
            return new List<string>(line.Split(' '));
        }

        public List<List<string>> GetLinesSplittedByWords()
        {
            List<List<string>> result = new List<List<string>>();
            foreach(string line in this.content)
            {
                List<string> words = new List<string>(line.Split(' '));
                result.Add(words);
            }
            return result;
        }
    }
}
