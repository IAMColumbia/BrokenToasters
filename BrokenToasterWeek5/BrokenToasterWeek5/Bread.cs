using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokenToasterWeek4
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
    }
}
