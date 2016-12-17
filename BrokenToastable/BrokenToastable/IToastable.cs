using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrokenToastable
{
    public interface IToastable
    {
        bool isToasted { get; set; }

        void Toast();

        string AboutToastable();
    }
}
