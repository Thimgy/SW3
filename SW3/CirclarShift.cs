using System;
using System.Collections.Generic;

namespace SW3
{
    public class CircluarShift
    {

        private List<string> shifted;

        public CircluarShift() {
            this.shifted = new List<string>();
        }

        public List<string> GetListShifts(List<List<string>> wordList)
        {
            foreach (List<String> list in wordList)
            {
                for (int i = 0; i<list.Count; i++)
                {
                    shifted.Add(String.Join(' ', list));
                    //shifted.Add(GenerateLine(list));
                    Shift(list);
                }
            }
            return shifted;
        }

        /*public String GenerateLine(List<String> arg) {
            String temp = "";
            foreach (String s in arg) {
                temp += s + " ";
            }
            temp = temp.Substring(0, temp.Length - 1);
            return temp;
        }*/

        public void Shift(List<String> arg)
        {
            String temp = arg[0];
            arg.RemoveAt(0);
            arg.Add(temp);


        }
        
    }
}