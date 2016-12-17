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
        static int count;
        static DateTime startTime, endTime;
        
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

            
                //Loop through number of request toasts while the toaster isn't broken
            Toast(NumberOfSlotsForToast, isBroken, numberOfToastsRequested);
            Console.ReadKey();
            ToastParallel(NumberOfSlotsForToast, isBroken, numberOfToastsRequested);
            

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        

        private static void Toast(int NumberOfSlotsForToast, bool isBroken, int numberOfToastsRequested)
        {
            ToastStart();
            for (int i = 0; i < numberOfToastsRequested; i++)
            {

                DoToast(NumberOfSlotsForToast, numberOfToastsRequested, i);
            }
            ToastEnd();
        }

        private static void ToastParallel(int NumberOfSlotsForToast, bool isBroken, int numberOfToastsRequested)
        {
            ToastStart();
            Parallel.For(0, numberOfToastsRequested, i =>
            {
                DoToast(NumberOfSlotsForToast, numberOfToastsRequested, i);
            });
            ToastEnd();
        }

        private static void ToastEnd()
        {
            endTime = System.DateTime.Now;
            Console.WriteLine(string.Format("Start: {0}\tEnd: {1}\tElapsed: {2} seconds",
                startTime.ToLongTimeString(),
                endTime.ToLongTimeString(),
                endTime.Subtract(startTime).TotalSeconds));
            Console.WriteLine("Press any key to continue...");
        }

        private static void ToastStart()
        {
            count = 0;
            startTime = System.DateTime.Now;
        }
        

        private static void DoToast(int NumberOfSlotsForToast, int numberOfToastsRequested, int i)
        {
            Console.WriteLine(string.Format("Filling slot {0} with toast {1}", (i % NumberOfSlotsForToast) + 1, i + 1));
            //If slot are full toast
            if (i % NumberOfSlotsForToast == NumberOfSlotsForToast - 1)
            {
                Console.WriteLine(string.Format("Toasting... {1}:{0}",
                    (double)numberOfToastsRequested / (double)NumberOfSlotsForToast, //total runs
                    count+1
                    ));

                System.Threading.Thread.Sleep(2000);
                count++;

            }
        }

        
    }
}
