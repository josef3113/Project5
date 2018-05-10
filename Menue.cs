using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    class MainMenue 
    {
        
        public List<MethodToDo> m_ListOfMenue = new List<MethodToDo>();

        public void AddMethod(string i_TitleMethod , MetodToPlay i_Function)
        {
            MethodToDo insert = new MethodToDo(i_TitleMethod, m_ListOfMenue.Count +1, i_Function);
            m_ListOfMenue.Add(insert);
        }

        public void ShowMenue()
        {
            bool quit = false;
            int userChoich;

            while (!quit)
            {
                Console.WriteLine("0.Exit");
                foreach (MethodToDo item in m_ListOfMenue)
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
                    foreach (MethodToDo item in m_ListOfMenue)
                    {
                        if (item.OptionNum == userChoich)
                        {
                            item.OnSelected();
                            break;
                        }
                    }

                }

            }
        }
    }
}
