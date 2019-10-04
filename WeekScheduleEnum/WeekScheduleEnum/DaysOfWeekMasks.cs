using System;

namespace WeekScheduleEnum
{
    [Flags]
    enum DaysOfWeekMasks : byte
    {
        None = 0x00,
        Monday = 0x01,
        Tuesday = 0x02,
        Wednesday = 0x04,
        Thursday = 0x08,
        Friday = 0x10,
        Sunday = 0x20,
        Saturday = 0x40
    }
}
