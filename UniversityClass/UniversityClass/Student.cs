using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClass
{
    class Student
    {
        public string Name;
        public Sex Gender;
        public string INN;
        public Subject[] marks;

       
        public Student(Sex gender)
        {
            Gender = gender;
            Name = Initillizator.GetRandomNameOfStudent(Gender);
            INN = Initillizator.GetRandomInnOfStudent();
            marks = new Subject[3];
            for (int i = 0; i < 3; i++)
            {
                marks[i] = new Subject(Initillizator.GetRandomAvarangeMark());
            }
        }

        public Student(Student pupil)
        {
            Name = pupil.Name;
            Gender = pupil.Gender;
            INN = pupil.INN;
            marks = new Subject[3];
            for (int i = 0; i < 3; i++)
            {
                marks[i] = new Subject(pupil.marks[i].AvarengeMark);
            }
        }
         
    }
}
