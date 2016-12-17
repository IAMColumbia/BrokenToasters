using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokenToastable
{
    class Program
    {
        static void Main(string[] args)
        {
            Toaster toaster = new Toaster();
            toaster.Slots.Add(new Bagel());
            toaster.Slots.Add(new Bread());

            Console.WriteLine(toaster.About());
            toaster.Cook();
            Console.WriteLine(toaster.About());
            
            Console.ReadKey();
        }
    }
}
