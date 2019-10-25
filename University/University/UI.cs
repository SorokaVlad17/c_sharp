using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class UI
    {
        public static KindOfInitilization GetKindOfInitilization()
        {
            KindOfInitilization initilization = KindOfInitilization.NoInitilization;
            do
            {

            switch(Console.ReadKey(true).Key)
            {
                    case ConsoleKey.H:
                        {
                            initilization = KindOfInitilization.ByHand;
                            break;
                        }
                    case ConsoleKey.R:
                        {
                            initilization = KindOfInitilization.Random;
                            break;
                        }
            }

            }while (initilization == KindOfInitilization.NoInitilization);

            return initilization;
        }
        public static void EnterInformationAboutGroup()
        {

        }
        public static void PrintGroup(Group group)
        {
            Console.WriteLine(group.Name);
            int sch = 0;
           foreach(Student person in group.Students)
           {
                ++sch; 
                Console.WriteLine("{3} {0} {1} {2}",person.Name,person.Gender.ToString(), person.INN,sch);
                
           }
            Console.WriteLine();
        }
        public static Action GetAction()
        {
            Action act = Action.NoAction;
            do
            {

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        {
                            act = Action.Add;
                            break;
                        }
                    case ConsoleKey.D:
                        {
                            act = Action.Delete;
                            break;
                        }
                    case ConsoleKey.U:
                        {
                            act = Action.Update;
                            break;
                        }
                }

            } while (act == Action.NoAction);

            return act;
        }
      //  public static EnterAction
    }
}
