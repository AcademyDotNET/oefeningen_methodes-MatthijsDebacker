using System;

namespace OudeOefeningenLeesbaarMaken
{
    class Program
    {
        enum Colors
        {
            black,
            brown,
            red,
            orange,
            yellow,
            green,
            blue,
            magenta,
            gray,
            white
        }

        static void Main(string[] args)
        {
            // Kleurcode Weerstand Naar Ohm Met Enum
            string ringOne = AskForString("What color is the first ring?").ToLower();
            string ringTwo = AskForString("What color is the second ring?").ToLower();
            string ringThree = AskForString("What color is the third ring?").ToLower();

            CalculateOhm(ringOne, ringTwo, ringThree);

            // For Doordenkers Extra
            int height = AskForInteger("How high should I draw my pyramid?");
            DrawPyramid(height);
        }

        static void CalculateOhm(string ringOne, string ringTwo, string ringThree)
        {
            if (ringThree == "gray" || ringThree == "white")
            {
                Console.WriteLine("Invalid color for the third ring!");
            }
            else
            {
                bool b1 = Enum.TryParse(ringOne, out Colors ring1C);
                bool b2 = Enum.TryParse(ringOne, out Colors ring2C);
                bool b3 = Enum.TryParse(ringOne, out Colors ring3C);

                if (b1 && b2 && b3)
                {
                    Console.WriteLine($"The resistance is {((10 * (int)ring1C) + (int)ring2C) * Math.Pow(10, (int)ring3C)} Ohm");
                }
                else
                {
                    Console.WriteLine("Could not parse the given colors.");
                }
            }
        }

        static void DrawPyramid(int height)
        {
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine(new string(' ', height - i) + new string('*', i * 2 + 1));
            }
        }

        static string AskForString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static int AskForInteger(string question)
        {
            Console.WriteLine(question);
            int input = 0;

            string sInput = Console.ReadLine();
            while (!int.TryParse(sInput, out input))
            {
                Console.Clear();
                Console.WriteLine("Invalid number, please try again.");
                sInput = Console.ReadLine();
            }

            return input;
        }
    }
}
