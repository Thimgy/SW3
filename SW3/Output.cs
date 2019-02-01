using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SW3
{
    public class Output : IDisposable
    {
        private StreamWriter writer;
        private bool fstLine = true;
        
        public Output(string path)
        {
            this.writer = new StreamWriter(path);
        }
        
        public void Dispose()
        {
            this.writer.Dispose();
        }
        
        public void WriteLines(List<string> lines)
        {
            int i = 0;
            if (this.fstLine)
            {
                this.fstLine = false;
                this.writer.Write(lines[0]);
                i = 1;
            }
            for (; i<lines.Count; ++i)
            {
                this.writer.Write(Environment.NewLine + lines[i]);
            }
        }
    }
}
