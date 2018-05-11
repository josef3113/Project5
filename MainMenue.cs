using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    public delegate void MetodToPlay();
    class MainMenue 
    {
        public string Title { get; set; }
        public List<IMenueItem> m_ListOfMenue = new List<IMenueItem>();

        public void AddMethod(string i_TitleMethod , MetodToPlay i_Function)
        {
            MethodToDo insert = new MethodToDo(i_TitleMethod, m_ListOfMenue.Count + 1, i_Function);
            m_ListOfMenue.Add(insert);
        }

        public void AddSubMenue(SubMenue i_SubMenueToAdd)
        {
            i_SubMenueToAdd.OptionNum = m_ListOfMenue.Count + 1;
            m_ListOfMenue.Add(i_SubMenueToAdd);
        }

        public virtual void ShowBack()
        {
            Console.WriteLine("0.Exit");
        }
        public void ShowMenue()
        {
            bool quit = false;
            int userChoich;

            while (!quit)
            {
                ShowBack();
                foreach (IMenueItem item in m_ListOfMenue)
                {
                    Console.WriteLine("{0}.{1}", item.OptionNum, item.Title);
                }

                Console.WriteLine("insert your choich");

                while (!int.TryParse(Console.ReadLine(), out userChoich))
                {
                    Console.WriteLine("wrong input try again");
                }

                if(userChoich == 0)
                {
                    quit = true;
                }
                else
                {
                    if(userChoich > m_ListOfMenue.Count)
                    {
                        Console.WriteLine("wrong input");
                    }
                    else
                    {
                        m_ListOfMenue[userChoich - 1].OnSelected();
                    }

                }

            }
        }
    }
}