using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week
{
    class Program
    {


        public static void DrawEnglishScheudle()
        {
            Console.WriteLine("Press number on keyboard that show day of week");
            Console.WriteLine("Press R on keyboard that translate days of week on russian");
            Console.WriteLine("Press T on keyboard that enter number and program show day of week");
            Console.WriteLine("Press Y on keyboard that enter line and program show how to translate this day on russian \n");
            Console.WriteLine("Monday - 1");
            Console.WriteLine("Tuesday - 2");
            Console.WriteLine("Wednesday - 3");
            Console.WriteLine("Thursday - 4");
            Console.WriteLine("Friday - 5");
            Console.WriteLine("Sunday - 6");
            Console.WriteLine("Saturday - 7");


        }

        public static void DrawRussianSchedule()
        {

            Console.WriteLine("Нажмите на число на клавиатуре что бы вывело день недели");
            Console.WriteLine("Нажмите E на клавиатуре что бы превести все на англиский");
            Console.WriteLine("Нажмите T на клавиатуре что бы ввести номер и показать день недели");
            Console.WriteLine("Нажмите Y на клавиатуре что бы ввести день недели и показать его номер");
            Console.WriteLine("Понедельник - 1");
            Console.WriteLine("Вторник - 2");
            Console.WriteLine("Среда - 3");
            Console.WriteLine("Четверг - 4");
            Console.WriteLine("Пятница - 5");
            Console.WriteLine("Суббота - 6");
            Console.WriteLine("Воскресенье - 7");

        }

        static void Main(string[] args)
        {

            Dictionary<int, string> daysOfweekOnRussian = new Dictionary<int, string>
            {
                {1,"Понедельник"},
                {2,"Вторник"},
                {3,"Среда"},
                {4,"Четверг"},
                {5,"Пятница"},
                {6,"Суббота"},
                {7,"Воскресенье"},
            };

            Languege languege = Languege.English;

   

            do
            {
                Console.Clear();


                switch (languege)
                {
                    case Languege.English:
                        {
                            DrawEnglishScheudle();

                            switch (Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.T:
                                    #region ENTER NUMBER
                                    {
                                        

                                        Console.WriteLine("Enter number");

                                        int number = 0;

                                        switch(Console.ReadKey(true).Key)
                                        {
                                            case ConsoleKey.D1:
                                                {
                                                    number = (int)DaysOfWeek.Monday;

                                                    break;
                                                }
                                            case ConsoleKey.D2:
                                                {
                                                    number = (int)DaysOfWeek.Tuesday;

                                                    break;
                                                }
                                            case ConsoleKey.D3:
                                                {
                                                    number = (int)DaysOfWeek.Wednesday;

                                                    break;
                                                }
                                            case ConsoleKey.D4:
                                                {
                                                    number = (int)DaysOfWeek.Thursday;

                                                    break;
                                                }
                                            case ConsoleKey.D5:
                                                {
                                                    number = (int)DaysOfWeek.Friday;

                                                    break;
                                                }
                                            case ConsoleKey.D6:
                                                {
                                                    number = (int)DaysOfWeek.Sunday;

                                                    break;
                                                }
                                            case ConsoleKey.D7:
                                                {
                                                    number = (int)DaysOfWeek.Saturday;

                                                    break;
                                                }
                                        }

                                        if (number != 0)
                                        {
                                   
                                            Console.WriteLine("This is a {0} ", (DaysOfWeek)number);

                                        }
                                        else
                                        {
                                            Console.WriteLine("Error");
                                        }


                                        Console.WriteLine("Press any button that to continue");

                                       

                                        break;
                                    }
                                #endregion
                                case ConsoleKey.Y:
                                    #region ENTER DAY OF WEEK
                                    {
                                        Console.WriteLine("Enter day of week and programm wiil show number ");

                                        string str = Console.ReadLine();

                                        DaysOfWeek day;

                                        if(Enum.TryParse<DaysOfWeek>(str , out day))
                                        {
                                            Console.WriteLine((int)day);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Error");
                                        }

                                        Console.WriteLine("Press any button that continue");


                                        break;
                                    }
                                #endregion
                                case ConsoleKey.R:
                                    #region CHANGE LANGUAGE ON RUSSIAN
                                    {

                                        languege = Languege.Russian;


                                        break;
                                    }
                                    #endregion
                            }

                            break;
                        }
                    case Languege.Russian:
                        {

                            DrawRussianSchedule();

                            switch (Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.T:
                                    #region ENTER NUMBER
                                    {


                                        Console.WriteLine("Введите число");

                                        int number = 0;

                                        switch (Console.ReadKey(true).Key)
                                        {
                                            case ConsoleKey.D1:
                                                {
                                                    number = (int)DaysOfWeek.Monday;

                                                    break;
                                                }
                                            case ConsoleKey.D2:
                                                {
                                                    number = (int)DaysOfWeek.Tuesday;

                                                    break;
                                                }
                                            case ConsoleKey.D3:
                                                {
                                                    number = (int)DaysOfWeek.Wednesday;

                                                    break;
                                                }
                                            case ConsoleKey.D4:
                                                {
                                                    number = (int)DaysOfWeek.Thursday;

                                                    break;
                                                }
                                            case ConsoleKey.D5:
                                                {
                                                    number = (int)DaysOfWeek.Friday;

                                                    break;
                                                }
                                            case ConsoleKey.D6:
                                                {
                                                    number = (int)DaysOfWeek.Sunday;

                                                    break;
                                                }
                                            case ConsoleKey.D7:
                                                {
                                                    number = (int)DaysOfWeek.Saturday;

                                                    break;
                                                }
                                        }

                                        if (number != 0)
                                        {

                                            Console.WriteLine("Это {0} ", daysOfweekOnRussian[number]);

                                        }
                                        else
                                        {
                                            Console.WriteLine("Ошибка");
                                        }


                                        Console.WriteLine("Нажмите любую кнопкку что бы продолжить");



                                        break;
                                    }
                                #endregion
                                case ConsoleKey.Y:
                                    #region ENTER DAY OF WEEK
                                    {
                                        Console.WriteLine("Введите название дня недели и программа выведит число ");

                                        string str = Console.ReadLine();

                                        DaysOfWeek day;

                                        if (Enum.TryParse<DaysOfWeek>(str, out day))
                                        {
                                            Console.WriteLine((int)day);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ошибка");
                                        }

                                        Console.WriteLine("Нажмите любое число чтобы продолжить");


                                        break;
                                    }
                                #endregion
                                case ConsoleKey.E:
                                   #region CHANGE LANGUAGE ON ENGLISH
                                    {

                                        languege = Languege.English;


                                        break;
                                    }
                                    #endregion
                            }

                            break;

                        }

                }


            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
