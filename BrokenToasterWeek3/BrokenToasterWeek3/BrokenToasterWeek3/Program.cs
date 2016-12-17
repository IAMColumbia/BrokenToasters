using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokenToasterWeek3
{
    class Program
    {
        static Random r = new Random();
        
        static void Main(string[] args)
        {

            const int NumberOfSlotsForToast = 4;
            bool isBroken = false;
            
            
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

            isBroken = false;
            if(isBroken == true)
            {
                Console.WriteLine("Sorry I can't make toast I'm broken.");
            }
            else
            {
                //Loop through number of request toasts while the toaster isn't broken
                for (int i = 0; i < numberOfToastsRequested; i++)
                {
                    
                    Console.WriteLine(string.Format("Filling slot {0} with toast {1}",  (i % NumberOfSlotsForToast) +1 , i + 1));

                    
                    //If slot are full toast
                    if ( i % NumberOfSlotsForToast == 3)
                    {
                        //Sometimes my toaster breaks when I try to toast something
                        do
                        {
                            Console.WriteLine("Trying to Toast");
                            //Randomly break toaster 1/3 of the time it will be broken 2/3 it will be fixed
                            isBroken = RandomlyBreakToaster();
                            if (!isBroken)
                            {
                                Console.WriteLine("Toasting...");
                            }
                            else
                            {
                                Console.WriteLine("Toaster is Broken trying to fix...");
                            }
                            System.Threading.Thread.Sleep(600);
                        } while (isBroken == true);
                    }
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static bool RandomlyBreakToaster()
        {
            //Break 1/3 of the time
            if (r.Next(3) == 0)
            {
                return true;
            }
            return false;
        }
    }
}
