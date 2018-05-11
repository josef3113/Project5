using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    internal class MethodToDo : ISubMenueItem
    {
        private MetodToPlay m_Method;

        public int SerialNumber { get; set; }

        public string Title { get;private set; }

        public MethodToDo(string i_Title, int i_SerialNumber, MetodToPlay i_Function)
        {
            m_Method = i_Function;
            Title = i_Title;
            SerialNumber = i_SerialNumber;
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
