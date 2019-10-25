using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Will you be a enter group by hand(H) or random(R) ?");
            KindOfInitilization initilization = UI.GetKindOfInitilization();

            switch(initilization)
            {
                case KindOfInitilization.ByHand:
                    {
                        UI.EnterInformationAboutGroup();

                        break;
                    }
                case KindOfInitilization.Random:
                    {
                        Group form = Initilization.GetRandomInitilizationGroup();
                        UI.PrintGroup(form);

                        do
                        {

                            Action act = UI.GetAction();
                            switch(act)
                            {
                                case Action.Add:
                                    {
                                        form.AddStudent(Initilization.GetRandomStudent());
                                        UI.PrintGroup(form);
                                        break;
                                    }
                                case Action.Delete:
                                    {
                                        form.DeleteStudent(form.Students[Initilization.GetRandomIdOfStudent(form)].INN);
                                        UI.PrintGroup(form);
                                        break;
                                    }
                                case Action.Update:
                                    {
                                        form.UpdateStudent(Initilization.GetRandomIdOfStudent(form));
                                        UI.PrintGroup(form);
                                        break;
                                    }
                  
                            }
                          

                        } while (true);
                        //Student p1 = Initilization.GetRandomStudent();
                        //form.AddStudent(p1);
                        //UI.PrintGroup(form);
                        //form.DeleteStudent(Console.ReadLine());
                        //UI.PrintGroup(form);
                        break;
                    }
            }

        }
    }
}
