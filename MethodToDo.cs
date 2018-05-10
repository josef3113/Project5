using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    public delegate void Notifyer<T>();
    class MethodToDo
    {
       public event Notifyer<int> m_Method;
       
        public int OptionNum { get; set; }
        public string Title { get; set; }

        public MethodToDo(string i_Title, int i_OptionNum)
        {
            Title = i_Title;
            OptionNum = i_OptionNum;
        }
        public void OnSelected()
        {
            if(m_Method != null)
            {
                m_Method.Invoke();
            }

        }
    }

    
}
