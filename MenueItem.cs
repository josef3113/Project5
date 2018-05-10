using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    interface  IMenueItem
    {
        void OnSelected();
        int OptionNum { get; }
        string Title { get; }

    }
}
