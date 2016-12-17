using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* There are 3 errors and a waring please fix the above code to have the output below
             * Correct output
             * Broken Toaster 9000!!!
             * What is your name?      :Jeff
             * How many toasts would you like?5
             * Sorry I can only make 4 toasts please try a different toaster.
             * Press any key to exit...
             */

namespace OOPBrokenToaster
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NumberOfSlotsForToast = 4;
            const bool isBroken = false;
            
            //Console.WriteLine writes a line of text followed by an new line
            Console.WriteLine("Broken Toaster 9000!!!");
            
            //Console.Write write a line of text without a new line
            Console.Write("What is your name?\t:");  //\t is the tab character
            
            //Declare a string
            string Name;
            
            //Store the users name in that string
            //Console.ReadLine read a line from the console and returns the results as a string
            Name = Console.ReadLine();
            
            Console.Write("How many toasts would you like?");
            
            //Declare and initialize int for number of toasts requests.
            int numberOfToastsRequested = 0;        //Default number of slices of toasts
            numberOfToastsRequested = int.Parse(Console.ReadLine());
            //I could also use an out parameter and a TryParse
            //int.TryParse(Console.ReadLine(), out numberOfToastsRequested);

            //isBroken = false;
            if(isBroken == true)
            {
                Console.WriteLine("Sorry I can't make toast I'm broken.");
            }
            else
            {
            
                if(numberOfToastsRequested > NumberOfSlotsForToast)
                {
                    Console.WriteLine(string.Format("Sorry I can only make {0} toasts please try a different toaster.", NumberOfSlotsForToast));
                }
                else
                {
                    Console.WriteLine(string.Format("Toasting {0} pieces of toast in {1} slots", numberOfToastsRequested, NumberOfSlotsForToast));
                    System.Threading.Thread.Sleep(600); //wait for toast
                    Console.WriteLine("Toasted...");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            
        }
    }
}
