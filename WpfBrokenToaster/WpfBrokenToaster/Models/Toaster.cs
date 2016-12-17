using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Toaster
    {
        //Fields
        public const int NumberOfSlotsForToast = 4;
        public bool isBroken;

        Bread[] Slots;  //Array of breads in the toaster slots ready to be toasted

        Random r = new Random(); //For randomly breaking the toaster

        //Constructor
        public Toaster()
        {
            this.isBroken = false;
            this.Slots = new Bread[4];
        }


        //Methods
        /// <summary>
        /// Toasts all the breads in the toaster
        /// </summary>
        /// <returns></returns>
        public string Toast()
        {
            string toasty = string.Empty;
            if (!(this.isBroken))
            {
                foreach (var bread in Slots)
                {

                    if (bread != null)
                    {
                        bread.Toast();
                        toasty += string.Format("Slot {0} toasted.\t", Array.IndexOf(Slots, bread));
                    }
                    toasty += this.About();
                    
                }
            }
            else
            {
                toasty = "Toaster is broken!";
            }
            this.Slots = new Bread[NumberOfSlotsForToast];  //empty toaster
            return toasty;
        }


        /// <summary>
        /// Checks to see if all the current slots are full
        /// </summary>
        /// <returns>True is all slots are full or False if there are empty slots</returns>
        public bool SlotsFull()
        {
            for (int i = 0; i < Slots.Length; i++)
            {
                if (Slots[i] == null)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Fill next available slot with bread
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool FillNextSlot(Bread b)
        {
            for (int i = 0; i < NumberOfSlotsForToast; i++) //loop through slots
            {
                if (Slots[i] == null)   //look for emptry slot
                {
                    Slots[i] = b;       //fill empty slot
                    return true;        //slot filled we are outa here
                }
            }
            //If no slots are empty return false
            return false;
        }

        /// <summary>
        /// Our toaster breaks 1/3 of the time
        /// </summary>
        /// <returns></returns>
        public  bool RandomlyBreakToaster()
        {
            //Break 1/3 of the time
            if (r.Next(3) == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns a string that shows the status of the toaster
        /// </summary>
        /// <returns>string about toaster</returns>
        public string About()
        {
            string s = string.Format("Broken Toaster 9000! Status: \n");
            for (int i = NumberOfSlotsForToast - 1; i >= 0 ; i--)
			{
                if (Slots[i] == null)
                {
                    s += string.Format("{0} slot is empty\n", i);
                }
                else
                {
                    s += string.Format("{0} in slot {1} {2}\n", Slots[i],i, Slots[i].GetToastedString());
                }
			}
            return s;
        }

    }
}
