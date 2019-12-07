using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClass
{
    class UI
    {
        public static void PrintGroup(Group group)
        {
            Console.WriteLine(group.Name);
            int sch = 0;

            foreach (Student person in group.Students)
            {
                ++sch;
                float avarenge = 0;
                for (int i = 0; i < person.marks.Length; i++)
                {
                    Subject subject = person.marks[i];
                    avarenge += subject.AvarengeMark;

                }
                avarenge /= 3;
                Console.WriteLine("{3} {0} {1} {2} {4}", person.Name, person.Gender.ToString(), person.INN, sch, avarenge);

            }
            Console.WriteLine();
        }
    }
}
