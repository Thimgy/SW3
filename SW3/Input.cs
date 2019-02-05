using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace SW3
{
    public class Input
    {
        private IList<String> content;

        public Input(String path)
        {
            List<String> temp = new List<String>();
            using (StreamReader sr = new StreamReader(path))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    temp.Add(line);
                }
            }
            this.content = temp.AsReadOnly();
        }
        
        public IList<String> GetLines()
        {
            return this.content;
        }

        public List<List<String>> GetLinesSplittedByWords()
        {
            List<List<String>> result = new List<List<String>>();
            foreach(String line in this.content)
            {
                List<String> words = new List<String>(line.Split(' '));
                result.Add(words);
            }
            return result;
        }
    }
}
