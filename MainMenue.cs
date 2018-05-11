using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    public delegate void MetodToPlay();

    public class MainMenue 
    {
        public string Title { get; private set; }

        private readonly List<ISubMenueItem> r_ListOfMenue = new List<ISubMenueItem>();

        public MainMenue(string i_TitleOfMenue)
        {
            Title = i_TitleOfMenue;
        }

        public void AddMethod(string i_TitleMethod , MetodToPlay i_MethodToPlay)
        {
            MethodToDo insert = new MethodToDo(i_TitleMethod, r_ListOfMenue.Count + 1, i_MethodToPlay);
            r_ListOfMenue.Add(insert);
        }

        public void AddSubMenue(SubMenue i_SubMenueToAdd)
        {
            i_SubMenueToAdd.SerialNumber = r_ListOfMenue.Count + 1;
            r_ListOfMenue.Add(i_SubMenueToAdd);
        }

        protected virtual void showBack()
        {
            Console.WriteLine("0.Exit");
        }

        private void showOption()
        {
            foreach (ISubMenueItem item in r_ListOfMenue)
            {
                Console.WriteLine("{0}.{1}", item.SerialNumber, item.Title);
            }
        }

        public void ShowMenue()
        {
            bool quit = false;
            int userChoich;

            while (!quit)
            {
                Console.WriteLine(Title);
                showBack();
                showOption();
                Console.WriteLine("insert your choich");

                while (!int.TryParse(Console.ReadLine(), out userChoich))
                {
                    Console.WriteLine("wrong input try again");
                }

                if (userChoich == 0)
                {
                    quit = true;
                    Console.Clear(); // book think about the right place for that
                }
                else
                {
                    if(userChoich > r_ListOfMenue.Count)
                    {
                        Console.WriteLine("wrong input");
                    }
                    else
                    {
                        Console.Clear(); // book think about the right place for that
                        r_ListOfMenue[userChoich - 1].OnSelected();
                    }
                }
            }
        }
    }
}
