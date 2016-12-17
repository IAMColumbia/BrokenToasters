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

        Bread[] Slots;

        Random r = new Random(); //For randomly breaking the toaster

        //Constructor
        public Toaster()
        {
            this.isBroken = false;
            this.Slots = new Bread[4];
        }


        //Methods
        public string Toast()
        {
            string toasty = string.Empty;
            foreach (var bread in Slots)
            {
                if(!(this.isBroken))
                {
                    bread.Toast();
                    toasty += string.Format("Slot {0} toasted.", Array.IndexOf(Slots, bread));
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
