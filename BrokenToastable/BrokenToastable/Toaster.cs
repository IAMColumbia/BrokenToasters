using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrokenToastable
{
    public class Toaster : ICooker
    {
        public List<IToastable> Slots { get; set; }

        public Toaster()
        {
            this.Slots = new List<IToastable>();
        }


        public void Toast()
        {
            this.Cook();
        }

        public void Cook()
        {
            foreach(IToastable toastable in Slots)
            {
                toastable.isToasted = true;
            }
        }

        public string About()
        {
            string about = "";
            foreach (IToastable t in Slots)
            {
                about += "slot " + Slots.IndexOf(t).ToString() + " " + t.AboutToastable() + System.Environment.NewLine;
            }
            return about;
        }
    }
}
