using System;
using System.Collections.Generic;
using System.Text;

namespace SW3
{
    class StoringLines
    {
        private List<List<String>> list;

        public StoringLines(List<String> lines) {
            list = GetLinesSplittedByWords(lines);
        }

        private List<List<String>> GetLinesSplittedByWords(List<String> lines)
        {
            List<List<String>> result = new List<List<String>>();
            foreach (String line in lines)
            {
                List<String> words = new List<String>(line.Split(' '));
                result.Add(words);
            }
            return result;
        }

        public List<List<String>> GetList() {
            return list;
        }

    }
}
