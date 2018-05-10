using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    class SubMenue : MainMenue , IMenueItem
    {
        public int OptionNum { get; set; }

        public SubMenue(string i_Title)
        {
            Title = i_Title;
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
