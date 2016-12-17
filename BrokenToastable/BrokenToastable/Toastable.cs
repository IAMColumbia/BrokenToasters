using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrokenToastable
{
    public abstract class Toastable : IToastable
    {

        public void Toast()
        {
            this.isToasted = true;
        }


        public virtual string AboutToastable()
        {
            return string.Format("{0} {1} toasted.", this, this.getToastedString());
        }

        private string getToastedString()
        {
            string toasty = "is";
            if (isToasted == false)
            {
                toasty = toasty.Replace("is", "is not");
            }
            return toasty;
        }

        public bool isToasted
        {
            get;

            set;

        }
    }
}
