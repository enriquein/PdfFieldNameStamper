using System;
using System.Collections.Generic;

namespace PdfFieldNameStamper
{
    public static class ConsoleRunner
    {
        public static void Run(List<string> arguments)
        {
            if (arguments.Count > 3)
            {
                Console.Write("\nIncorrect number of arguments. Correct command-line usage:\n\tPdfFieldNameStamper inputFullPdfPath [outputFullPdfPath]\n");
                return;
            }

            string inputPdf = arguments[1];
            string outputPdf = arguments.Count == 2 ? null : arguments[2];

            var stamper = new Stamper();
            try
            {
                Console.Write("\nBegin processing input file: " + inputPdf);
                Console.Write("\nStamping field names.");
                stamper.StampFields(inputPdf, outputPdf);
                Console.Write("\nDone.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAn error occurred while trying to stamp the fields. The error was: " + ex.Message);
                Console.WriteLine("\nDone.\n");
            }
        }
    }
}
