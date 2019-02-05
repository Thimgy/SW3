using System;
using System.Collections.Generic;

namespace SW3
{
    class Program
    {
        static void Main(String[] args)
        {
            // exit if not enough arguments are provided
            if(args.Length != 2)
            {
                Console.Error.WriteLine($"{AppDomain.CurrentDomain.FriendlyName} expect 2 arguments but {args.Length} were provided");
                Environment.ExitCode = 1;
                return;
            }

            String inputFile = args[0];
            String outputFile = args[1];

            Input input = new Input(inputFile);
            List<List<String>> lines = input.GetLinesSplittedByWords();

            CircluarShift cs = new CircluarShift(lines);
            List<String> shifts = cs.GetListShifts();

            AlphabeticalSort sorter = new AlphabeticalSort();
            List<String> sortedShifts = sorter.SortLines(shifts);

            Output output = new Output(outputFile);
            output.WriteLines(sortedShifts);
            output.Close();
        }
    }
}
