using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokenToasterWeek6
{
    /*The toaster out put should be like (the random may have different broken parts)
     *  Broken Toaster 9000!!!
        What is your name?      : jeff
        Hello jeff how many toasts would you like to make today? 8
        Broken Toaster 9000! Status:
        3 slot is empty
        2 slot is empty
        1 slot is empty
        0 slot is empty

        Broken Toaster 9000! Status:
        3 slot is empty
        2 slot is empty
        1 slot is empty
        BrokenToasterWeek6.Bread in slot 0 is not toasted

        Broken Toaster 9000! Status:
        3 slot is empty
        2 slot is empty
        BrokenToasterWeek6.Bread in slot 1 is not toasted
        BrokenToasterWeek6.Bread in slot 0 is not toasted

        Broken Toaster 9000! Status:
        3 slot is empty
        BrokenToasterWeek6.Bread in slot 2 is not toasted
        BrokenToasterWeek6.Bread in slot 1 is not toasted
        BrokenToasterWeek6.Bread in slot 0 is not toasted

        Broken Toaster 9000! Status:
        BrokenToasterWeek6.Bread in slot 3 is not toasted
        BrokenToasterWeek6.Bread in slot 2 is not toasted
        BrokenToasterWeek6.Bread in slot 1 is not toasted
        BrokenToasterWeek6.Bread in slot 0 is not toasted

        Slot 0 toasted.Slot 1 toasted.Slot 2 toasted.Slot 3 toasted.
        Broken Toaster 9000! Status:
        3 slot is empty
        2 slot is empty
        1 slot is empty
        0 slot is empty

        Broken Toaster 9000! Status:
        3 slot is empty
        2 slot is empty
        1 slot is empty
        BrokenToasterWeek6.Bread in slot 0 is not toasted

        Broken Toaster 9000! Status:
        3 slot is empty
        2 slot is empty
        BrokenToasterWeek6.Bread in slot 1 is not toasted
        BrokenToasterWeek6.Bread in slot 0 is not toasted

        Broken Toaster 9000! Status:
        3 slot is empty
        BrokenToasterWeek6.Bread in slot 2 is not toasted
        BrokenToasterWeek6.Bread in slot 1 is not toasted
        BrokenToasterWeek6.Bread in slot 0 is not toasted
     */

    class Program
    {

        static Toaster myToaster;

        static void Main(string[] args)
        {

            //Declare a new toaster
            myToaster = new Toaster();
            
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

            //Loop through requested toasts
            do
            {
                //Write toaster status
                
                
                //If toaster has free slots fill them
                if (myToaster.SlotsFull() == false)
                {
                    //Fill slot
                    
                    //Decrement requeted toasts
                    
                }
                else //toaster is full make toast
                {
                    
                }

            } while (numberOfToastsRequested > 0);

           
            Console.ReadKey();
        }

        
    }
}
