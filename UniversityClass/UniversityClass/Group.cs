using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClass
{
    class Group
    {
        public int CountStudents;
        public Student[] Students;
        public string Name;
        public Course term;
        public Group()
        {
            CountStudents = Initillizator.GetRandomCountOfGroup();
            Students = new Student[CountStudents];
            Name = Initillizator.GetRandomNameOfGroup();
            term = Course.First;
            for (int i = 0; i < Students.Length; i++)
            {
                Students[i] = new Student(Initillizator.GetRandomGenderOfStudent());
            }


        }
        public Group(Group form)
        {
            CountStudents = form.CountStudents;
            Name = form.Name;
            term = form.term + 1;
            for (int i = 0; i < form.Students.Length; i++)
            {
                Students[i] = new Student(form.Students[i]);
            }
        }
        #region Methods
        public void AddStudent(Student pupil)
        {
            ++CountStudents;
            Student[] pupils = (Student[])Students.Clone();
            Students = new Student[CountStudents];
            for (int i = 0; i < CountStudents - 1; i++)
            {
                Students[i] = new Student(pupils[i]);
            }
            Students[CountStudents - 1] = new Student(pupil);

        }
        public void DeleteStudent(Student pupil)
        {
            
            int idDeletStudent = -1;
            for (int i = 0; i < Students.Length; i++)
            {
                if(pupil.INN == Students[i].INN)
                {
                    idDeletStudent = i;
                }
            }
            
            if(idDeletStudent == -1)
            {
                return; 
            }

            int add = 0;
            --CountStudents;
            Student[] pupils = new Student[CountStudents];
            for (int i = 0; i < Students.Length; i++)
            {
                if(i == idDeletStudent)
                {
                    add = 1;
                }
                pupils[i] = new Student(Students[i + add]);

            }
            Students = (Student[])pupils.Clone();
        }

       public Group GetNewCourse()
        {
            return new Group(this);
        }



        #endregion
    }

}
