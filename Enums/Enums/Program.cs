using System;

namespace Enums
{

    enum Day
    {
        Mo,
        Tu,
        We,
        Th,
        Fr,
        Sa,
        Su
    };

    enum Month
    {
        January = 1,
        February = 8,
        Marts,
        April,
        May,
        June,
        July,
        August,
        September,
        Oktober,
        November,
        December
    };


    class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Fr;
            Day Su = Day.Su;

            Day a = Day.Fr;

            Console.WriteLine(fr==a);

            Console.WriteLine(Day.Mo);

            Console.WriteLine((int)Day.Mo);

            Console.WriteLine((int)Month.February);
            Console.WriteLine((int)Month.August);

        }
    }
}
