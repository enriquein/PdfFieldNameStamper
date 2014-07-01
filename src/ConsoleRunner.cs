using System;
using System.Collections.Generic;
using System.IO;

namespace PdfFieldNameStamper
{
    public static class ConsoleRunner
    {
        public static void Run(List<string> arguments)
        {
            StreamWriter standardOutput = new StreamWriter(Console.OpenStandardOutput());
            standardOutput.AutoFlush = true;
            Console.SetOut(standardOutput);

            if (arguments.Count > 3)
            {
                Console.Out.WriteLine("Incorrect number of arguments. Correct command-line usage:\n\tPdfFieldNameStamper inputFullPdfPath [outputFullPdfPath]");
                return;
            }

            string inputPdf = arguments[1];
            string outputPdf = arguments.Count == 2 ? null : arguments[2];

            var stamper = new Stamper();
            try
            {
                Console.WriteLine("Begin processing input file: " + inputPdf);
                Console.WriteLine("Stamping field names.");
                stamper.StampFields(inputPdf, outputPdf);
                Console.WriteLine("Done. New file created at: " + outputPdf);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while trying to stamp the fields. The error was: " + ex.Message);
                Console.WriteLine("Done.");
            }
        }
    }
}
