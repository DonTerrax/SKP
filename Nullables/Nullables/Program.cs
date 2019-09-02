using System;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 1337;

            double? num3 = new double();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            Console.WriteLine("Our nullable numbers are: {0},{1},{2},{3}",num1,num2,num3,num4);
            Console.WriteLine("The nullable boolean value is {0}", boolval);

            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("User is male");
            }else if (isMale == false)
            {
                Console.WriteLine("User is female");
            }
            else
            {
                Console.WriteLine("No gender choosen");
            }

            double? num6 = 13.1;
            double? num7 = null;
            double num8;
            if (num6 == null)
            {
                num8 = 0.0;
            }
            else
            {
                num8 = (double)num6;
            }

            Console.WriteLine("Value of num8 is {0}",num8);

            // Shorter: The null coalescing operator ??

            num8 = num6 ?? 8.53;
            Console.WriteLine("Value of num8 is {0}", num8);

            num8 = num7 ?? 8.53;
            Console.WriteLine("Value of num8 is {0}", num8);



        }
    }
}
