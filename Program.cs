using System;
using System.IO;
using InterpreterApp.Analysis;
using System.Diagnostics;

namespace InterpreterApp
{
    internal static class Program
    {
        static void Main()
        {
            // Read the code from the text file
         string codeFilePath = "C:\\Users\\John\\source\\repos\\InterpreterApp (Code Language)\\code.txt"; // Update this with the path to your text file
         
            string codeWithCarriageReturns = File.ReadAllText(codeFilePath);
            string code = codeWithCarriageReturns.Replace("\r", "");


            //  string code = "BEGIN CODE \n INT x=5+5 \n DISPLAY: x \nEND CODE";
            Console.WriteLine(code);


            try
            {
                // Execute the interpreter
                Interpreter program = new Interpreter(code);
                program.Execute();
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.StackTrace);
                Console.WriteLine(exception.Message);
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
