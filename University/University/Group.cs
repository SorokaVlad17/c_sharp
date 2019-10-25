using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    struct Group
    {
        public int CountStudents;
        public Student[] Students;
        public string Name;

        public void UpdateStudent(int id)
        {
            Students[id].Name = Initilization.GetRandomNameOfStudent(Students[id].Gender);
            Students[id].INN = Initilization.GetRandomInnOfStudent();
        }
        public void AddStudent(Student pupil)
        {
            ++CountStudents;
            Student[] newStudents = new Student[CountStudents];
            for (int i = 0; i < Students.Length; i++)
            {
                newStudents[i] = Students[i];
            }

            newStudents[CountStudents - 1] = pupil;
            Students = new Student[CountStudents];

            for (int j = 0; j < CountStudents; j++)
            {
                Students[j] = newStudents[j];
            }
        }
        public void DeleteStudent(string inn)
        {
            --CountStudents;
            Student[] newStudets = new Student[CountStudents];
            bool isHaveInn = false; 
            int pos = 0;
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].INN == inn)
                {
                    isHaveInn = true;
                    pos = i;
                    break;
                }
                newStudets[i] = Students[i];
            }

            if(!isHaveInn)
            {
                ++CountStudents;
                return;
            }

            for (int j = CountStudents; j > pos; j--)
            {
                newStudets[j - 1] = Students[j];
            }

            Students = new Student[CountStudents];

            for (int j = 0; j < CountStudents; j++)
            {
                Students[j] = newStudets[j];
            }
        }
    }
    
}
