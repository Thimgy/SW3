using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SW3
{
    public class Output
    {
        private StreamWriter writer;
        private bool fstLine = true;
        
        public Output(string path)
        {
            this.writer = new StreamWriter(path);
        }
        
        public void Close()
        {
            this.writer.Close();
        }
        
        public void WriteLines(List<string> lines)
        {
            if(lines.Count == 0)
            {
                return;
            }

            int i = 0;
            if (this.fstLine)
            {
                this.fstLine = false;
                this.writer.Write(lines[0]);
                i = 1;
            }
            for (; i<lines.Count-1; ++i)
            {
                this.writer.WriteLine(lines[i]);
            }
            this.writer.Write(lines[lines.Count - 1]);
        }
    }
}
