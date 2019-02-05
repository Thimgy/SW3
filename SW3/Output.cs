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
            
            if (this.fstLine)
            {
                this.fstLine = false;
            }
            else
            {
                this.writer.WriteLine();
            }
            for (int i=0; i<lines.Count-1; ++i)
            {
                this.writer.WriteLine(lines[i]);
            }
            this.writer.Write(lines[lines.Count - 1]);
        }
    }
}
