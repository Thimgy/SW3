using System;
using System.Collections.Generic;

namespace SW3
{
    class Program
    {
        static void Main(string[] args_)
        {
            string[] args = {"in.txt", "out.txt"};
            // basic parsing
            if(args.Length != 2)
            {
                Console.Error.WriteLine($"Execpected 2 argument, only received {args.Length}");
                Environment.Exit(1);
            }

            string inputFile = args[0];
            string outputFile = args[1];

            Input input = new Input();
            List<string> words = input.ReadWords(inputFile);

            // do stuff with words
            List<string> sortedLines = /*...*/words;


            Output output = new Output();
            output.WriteLines(outputFile, sortedLines);
        }
    }
}
