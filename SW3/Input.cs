using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace SW3
{
    public class Input
    {
        private List<String> content;

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
            this.content = temp;
        }
        
        public List<String> GetLines()
        {
            return this.content;
        }

        //Seperate class for bellow method

       
    }
}
