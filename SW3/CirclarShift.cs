using System;
using System.Collections.Generic;

namespace SW3
{
    public class CircluarShift
    {
        private List<String> shifted;

        public CircluarShift(List<List<String>> wordList)
        {
            this.shifted = new List<String>();
            this.ComputeListShifts(wordList);
        }

        private void ComputeListShifts(List<List<String>> wordList)
        {
            foreach (List<String> list in wordList)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    this.shifted.Add(GenerateLine(list));
                    Shift(list);
                }
            }
        }

        public List<String> GetListShifts()
        {
            return this.shifted;
        }

        public String GenerateLine(List<String> arg) {
            return String.Join(' ', arg);
        }

        public void Shift(List<String> arg)
        {
            String temp = arg[0];
            arg.RemoveAt(0);
            arg.Add(temp);
        }
        
    }
}