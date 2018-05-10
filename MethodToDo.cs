using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    public delegate void MetodToPlay();
   
    class MethodToDo : IMenueItem
    {
        public event MetodToPlay m_Method;

        public int OptionNum { get; set; }
        public string Title { get; set; }

        public MethodToDo(string i_Title, int i_OptionNum, MetodToPlay i_Function)
        {
            m_Method = i_Function;
            Title = i_Title;
            OptionNum = i_OptionNum;
        }

        public void OnSelected()
        {
            if (m_Method != null)
            {
                //m_Method();  // book think about this 
                m_Method.Invoke();
            }

        }
    }

    
}
