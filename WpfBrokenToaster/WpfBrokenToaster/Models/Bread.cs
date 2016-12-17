using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Bread
    {
        public bool IsToasted;
        public bool IsButtered;

        public Bread()
        {
            IsToasted = false;
        }

        public void Toast()
        {
            this.IsToasted = true;
        }

        public void Butter()
        {
            this.IsButtered = true;
        }

        /// <summary>
        /// String about bread being toasted
        /// </summary>
        /// <returns></returns>
        public string GetToastedString()
        {
            if (this.IsToasted)
            {
                return "is toasted";
            }
            return "is not toasted";
        }
    }
}
