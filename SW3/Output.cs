using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SW3
{
    public class Output
    {
        // todo doc & might throws
        public void WriteLines(string path, List<string> lines)
        {
            using (var sw = new StreamWriter(path))
            {
                foreach(var line in lines)
                {
                    sw.WriteLine(line);
                }
            }
        }
    }
}
