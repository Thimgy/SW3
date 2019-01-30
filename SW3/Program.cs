using System;
using System.Collections.Generic;

namespace SW3
{
    class Program
    {
        static void Main(string[] args)
        {
            // exit if not enough arguments are provided
            if(args.Length != 2)
            {
                Console.Error.WriteLine($"Expected 2 arguments, got {args.Length}");
                Environment.Exit(1);
            }

            string inputFile = args[0];
            string outputFile = args[1];

            Input input = new Input(inputFile);
            List<List<string>> lines = input.GetLinesSplittedByWords();

            CircluarShift cs = new CircluarShift();
            List<string> shifts = cs.GetListShifts(lines);

            AlphabeticalSort alphSort = new AlphabeticalSort();
            List<string> sortedShifts = alphSort.SortLines(shifts);

            using (Output output = new Output(outputFile))
            {
                output.WriteLines(sortedShifts);
            }
        }
    }
}
