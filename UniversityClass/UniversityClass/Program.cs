using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Group form = new Group();
            UI.PrintGroup(form);
            form.AddStudent(new Student(Initillizator.GetRandomGenderOfStudent()));
            UI.PrintGroup(form);
            form.DeleteStudent(new Student(Initillizator.GetRandomGenderOfStudent()));
            Group form2 = form.GetNewCourse();
            //UI.PrintGroup(form2);
        }
    }
}
