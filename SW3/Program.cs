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
                Console.Error.WriteLine($"{AppDomain.CurrentDomain.FriendlyName} expect 2 arguments but {args.Length} were provided");
                Environment.ExitCode = 1;
                return;
            }

            string inputFile = args[0];
            string outputFile = args[1];

            Input input = new Input(inputFile);
            List<List<string>> lines = input.GetLinesSplittedByWords();
            Content content = input.GetContent();

            CircluarShift cs = new CircluarShift();
            List<string> shifts = cs.GetListShifts(content);

            AlphabeticalSort sorter = new AlphabeticalSort();
            List<string> sortedShifts = sorter.SortLines(shifts);

            using (Output output = new Output(outputFile))
            {
                output.WriteLines(sortedShifts);
            }
        }
    }
}
