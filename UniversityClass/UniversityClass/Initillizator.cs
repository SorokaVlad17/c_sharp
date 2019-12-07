using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClass
{
    class Initillizator
    {
        static public Random rnd = new Random();
        static public int minCountStudents = 9;
        static public int maxCountStudents = 31;
        static public int minMark = 1;
        static public int maxMark = 100;

        public static float GetRandomAvarangeMark()
        {
            return rnd.Next(minMark, maxMark) + (float)rnd.NextDouble();
        }

        static public Sex GetRandomGenderOfStudent()
        {
            return (Sex)rnd.Next(0, 2);
        }

        static public int GetRandomIdOfStudent(Group form)
        {
            return rnd.Next(0, form.CountStudents);
        }
        static public string GetRandomInnOfStudent()
        {
            return rnd.Next(1, 100000000).ToString();
        }
        static public string GetRandomNameOfStudent(Sex gender)
        {
            string[] namesOfMen = new string[] {"Anton","Roman","Yura","Vlad","Andrew","Alex","Fedor","Nikita",
                "Ivan","Igor","Sergey","Artem","Danil","Yan","David","Max"
            };
            string[] namesOfWeman = new string[] {"Anya","Dasha","Katya","Lera","Vika","Rita","Liza","Sasha","Nastya",
            "Masha","Marina","Ksenia",};

            string name;

            if (gender == Sex.Male)
            {
                name = namesOfMen[rnd.Next(0, namesOfMen.Length)];
            }
            else
            {
                name = namesOfWeman[rnd.Next(0, namesOfWeman.Length)];
            }
            return name;
        }

        static public string GetRandomNameOfGroup()
        {
            return rnd.Next(1, 1000000).ToString();
        }

        static public int GetRandomCountOfGroup()
        {
            return rnd.Next(minCountStudents, maxCountStudents);
        }
    }
}
