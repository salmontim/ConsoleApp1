using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("L003 Audit Start");
            Console.WriteLine("Step 1: Verify if the IP address matches with specific computer names");
            Console.WriteLine("Please input the standard list file:");
            String stdNameIP = Console.ReadLine().ToString();
            Console.WriteLine(stdNameIP);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
