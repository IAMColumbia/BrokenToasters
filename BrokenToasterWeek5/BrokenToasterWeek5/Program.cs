using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokenToasterWeek4
{
    /*The toaster out put should be like (the random may have different broken parts)
     *  Broken Toaster 9000!!!
        What is your name?      : Jeff
        Hello Jeff how many toasts would you like to make today? 12
        Filling slot 1 with toast 1
        Filling slot 2 with toast 2
        Filling slot 3 with toast 3
        Filling slot 4 with toast 4
        Trying to Toast
        Toaster is Broken trying to fix...
        Trying to Toast
        Toaster is Broken trying to fix...
        Trying to Toast
        Toaster is Broken trying to fix...
        Trying to Toast
        Toasting...
        Filling slot 1 with toast 5
        Filling slot 2 with toast 6
        Filling slot 3 with toast 7
        Filling slot 4 with toast 8
        Trying to Toast
        Toasting...
        Filling slot 1 with toast 9
        Filling slot 2 with toast 10
        Filling slot 3 with toast 11
        Filling slot 4 with toast 12
        Trying to Toast
        Toasting...
        Press any key to exit...
     */

    class Program
    {
        
        
        static void Main(string[] args)
        {

            //Declare a new toaster
            Toaster myToaster;
            
            //Console.WriteLine writes a line of text followed by an new line
            Console.WriteLine("Broken Toaster 9000!!!");
            
            //Console.Write write a line of text without a new line
            Console.Write("What is your name?\t: ");  //\t is the tab character
            
            //Declare a string
            string Name;
            
            //Store the users name in that string
            //Console.ReadLine read a line from the console and returns the results as a string
            Name = Console.ReadLine();
            
            Console.Write(string.Format("Hello {0} how many toasts would you like to make today? ",Name));
            
            //Declare and initialize int for number of toasts requests.
            int numberOfToastsRequested = 0;        //Default number of slices of toasts
            int.TryParse(Console.ReadLine(), out numberOfToastsRequested);


            if (myToaster.isBroken == true)
            {
                Console.WriteLine("Sorry I can't make toast I'm broken.");
            }
            else
            {
                Console.WriteLine(myToaster.Toast(numberOfToastsRequested));
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        
    }
}
