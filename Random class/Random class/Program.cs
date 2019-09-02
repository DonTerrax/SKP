using System;

namespace Random_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Random yesNoMaybe = new Random();
            int answerNum;
            answerNum = yesNoMaybe.Next(3);
            

            if (answerNum == 1)
            {
                Console.WriteLine("Yes");
            }
            else if (answerNum == 2)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Maybe");
            }

        }
    }
}
