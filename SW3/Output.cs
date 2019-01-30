using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SW3
{
    // IDisposable => allow to write:
    //  using (Output out = new Output(path))
    //  {
    //    /*do stuff*/
    //  }
    //  // close everything
    // might be a bit too fancy, through
    public class Output : IDisposable
    {
        private StreamWriter writer;

        // todo doc & might throws
        public Output(string path)
        {
            this.writer = new StreamWriter(path);
        }
        
        public void Dispose()
        {
            this.writer.Dispose();
        }

        // todo doc
        public void WriteLines(List<string> lines)
        {
            foreach (var line in lines)
            {
                this.writer.WriteLine(line);
            }
        }
    }
}
