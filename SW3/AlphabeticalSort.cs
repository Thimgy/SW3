using System;
using System.Collections.Generic;

namespace SW3
{
    public class AlphabeticalSort
    {
        public List<string> SortLines(List<string> lines)
        {
            lines.Sort();
            return lines;
        }
    }
}