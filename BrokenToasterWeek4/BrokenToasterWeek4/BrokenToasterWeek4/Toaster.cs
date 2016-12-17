using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokenToasterWeek4
{
    class Toaster
    {
        //Fields
        public const int NumberOfSlotsForToast = 4;
        public bool isBroken;

        Random r = new Random(); //For randomly breaking the toaster

        //Constructor
        public Toaster()
        {
            this.isBroken = false;
        }


        //Methods
        public string Toast(int numberOfToasts)
        {
            string toasty = string.Empty;
            
            //Loop through number of request toasts while the toaster isn't broken
            for (int i = 0; i < numberOfToasts; i++)
            {
                    
                toasty = string.Format("\nFilling slot {0} with toast {1}",  (i % NumberOfSlotsForToast) +1 , i + 1);

                //If slot are full toast
                if (i % NumberOfSlotsForToast == NumberOfSlotsForToast-1)
                {
                    //Sometimes my toaster breaks when I try to toast something
                    do
                    {
                       toasty += "\nTrying to Toast";
                        //Randomly break toaster 1/3 of the time it will be broken 2/3 it will be fixed

                        this.isBroken = RandomlyBreakToaster();
                        if (!this.isBroken)
                        {
                            toasty+="\nToasting...";
                        }
                        else
                        {
                            toasty +="\nToaster is Broken trying to fix...";
                        }
                    
                    } while (this.isBroken == true);
                }
            }
            return toasty;
        }
        
        public  bool RandomlyBreakToaster()
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
