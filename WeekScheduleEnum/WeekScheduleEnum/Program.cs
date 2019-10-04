using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekScheduleEnum
{
    class Program
    {

        static void DrawWeek(string scheudle)
        {
            Console.WriteLine("MON TUE WED THU FRI SUN STR");

            Console.WriteLine(scheudle);


            Console.SetCursorPosition(1, 1);
        }

        static string GetSchedule(DaysOfWeekMasks days)
        {
            string schedule = " ";

            foreach (DaysOfWeekMasks mask in Enum.GetValues(typeof(DaysOfWeekMasks)))
            {
                if (mask == DaysOfWeekMasks.None)
                {
                    continue;
                }

                if (days.HasFlag(mask))
                {
                    schedule += "+   ";
                }

                else
                {
                    schedule += "-   ";
                }
            }
            return schedule;
        }
        static void Main(string[] args)
        {
            const byte MIN_CURSOR_POSITION = 1;

            const byte MAX_CURSOR_POSITION = 25;


            DaysOfWeekMasks days = DaysOfWeekMasks.None;

            byte nowDayOfWeek = 1;

            byte nowPosition = 1;

            DrawWeek(GetSchedule(days));


            for (; ; )
            {

                switch (Console.ReadKey(true).Key)
                {

                    case ConsoleKey.LeftArrow:
                        {
                            if (nowPosition == MIN_CURSOR_POSITION)
                            {
                                break;
                            }
                            else
                            {
                                nowPosition -= 4;
                                nowDayOfWeek--;
                            }

                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (nowPosition == MAX_CURSOR_POSITION)
                            {
                                break;
                            }
                            else
                            {
                                nowPosition += 4;
                                nowDayOfWeek++;
                            }

                            break;
                        }
                    case ConsoleKey.Enter:
                        {

                            days ^= DaysOfWeekMasks.None;

                            string dayToStr = Enum.GetNames(typeof(DaysOfWeekMasks))[nowDayOfWeek];

                            DaysOfWeekMasks day = (DaysOfWeekMasks)(Enum.Parse(typeof(DaysOfWeekMasks), dayToStr));

                            if (days.HasFlag(day))
                            {

                                days ^= day;
                            }
                            else
                            {

                                days |= day;
                            }

                            break;

                        }

                }

                Console.Clear();

                DrawWeek(GetSchedule(days));

                Console.SetCursorPosition(nowPosition, 1);

            }
        }
    }
}
