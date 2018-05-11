using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    class SubMenue : MainMenue , ISubMenueItem
    {
        public int OptionNum { get; set; }

        public SubMenue(string i_Title) : base(i_Title)
        {
        }

        public override void ShowBack()
        {
            Console.WriteLine("0.Back");
        }

        public void OnSelected()
        {
            ShowMenue();
        }
    }
}
