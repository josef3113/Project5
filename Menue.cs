using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    class Menue 
    {
        
        public List<MethodToDo> m_ListOfMenue = new List<MethodToDo>();
        public List<Notifyer<int>> m_Functin = new List<Notifyer<int>>();

        public Menue()
        {
        }

        public void AddMethod(string i_TitleMethod , Notifyer<int> i_Function)
        {
            MethodToDo insert = new MethodToDo(i_TitleMethod, m_ListOfMenue.Count +1);
            m_ListOfMenue.Add(insert);
            insert.m_Method += i_Function;
        }

        public void ShowMenue()
        {
            int indx = 1;
            foreach (MethodToDo item in m_ListOfMenue)
            {
                Console.WriteLine("{0}.{1}",indx++, item.Title);
            }

            Console.WriteLine("insert your choich");

            int userChoich;
            while (!int.TryParse(Console.ReadLine(), out userChoich))
            {
                Console.WriteLine("wrong input try again");
            }


            foreach (MethodToDo item in m_ListOfMenue)
            {
                if (item.OptionNum == userChoich)
                {
                    item.OnSelected();
                    break;
                }
            }

        }

        public void Print()
        {
            Console.WriteLine("hello");
        }

        private void Option(int i_Selected)
        {
            m_Functin[i_Selected].Invoke();
            //switch (i_Selected)
            //{
            //    case 1:
            //        Console.WriteLine("1");
            //        break;
            //    case 2:
            //        Console.WriteLine("2");
            //        break;
            //        defult:
            //        Console.WriteLine("wrong input try again");
            //        break;


            //}
        }


        public void Print(string i_Toprint)
        {
            int num;
            
            Console.WriteLine("this method in player insert num ");
            
            num = int.Parse( Console.ReadLine());
            Console.WriteLine(num);
            Console.WriteLine(i_Toprint);
        }

       

    }
}
