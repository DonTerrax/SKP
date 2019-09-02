using System;
using System.IO;

namespace Polymorphism_read_from_textfile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method 1
            string[] lines = {" first 250", "second 260", "third 390"};

            File.WriteAllLines(@"../../../highScores.txt",lines);
            /*
            // Method 2
            Console.WriteLine("Give the file a name:");
            string fileName = Console.ReadLine();

            Console.WriteLine("write to file:");
            string input = Console.ReadLine();

            File.WriteAllText(@"../../../" + fileName +".txt",input);
            */

            // Method 3

            using (StreamWriter file = new StreamWriter(@"../../../myText.txt"))
            {
                foreach (var line in lines)
                {
                    if (line.Contains("third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            //add text to a file
            using (StreamWriter file = new StreamWriter(@"../../../myText.txt", true))
            {
                file.WriteLine("Additional line");
            }





            /*
           //read from textfile
            string text = System.IO.File.ReadAllText(@"../../../textFile.txt");

            Console.WriteLine("textFile contains following text: {0}",text);

            string[] lines = System.IO.File.ReadAllLines(@"../../../textFile.txt");

            Console.WriteLine("Contents of textfile.txt are: ");
            foreach (var line in lines)
            {
                Console.WriteLine("\t"+ line);
            }
            Console.ReadKey();
            */

        }
    }
}
