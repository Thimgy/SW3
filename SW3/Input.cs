using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace SW3
{
    public class Input
    {
        // immutable representation of the content of the file
        // build in the constructor
        private IList<string> content;

        public Input(string path)
        {
            List<string> temp = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    temp.Add(line);
                }
            }
            this.content = temp.AsReadOnly();
        }
        
        public IList<string> GetLines()
        {
            return this.content;
        }

        public Content GetContent()
        {
            return new Content(this.content);
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
