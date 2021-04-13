using System;

namespace MuziekEnMethoden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a song to play: ");
            Console.WriteLine("1) You Are My Sunshine.");
            Console.WriteLine("2) March Of The Toy Soldier.");
            Console.WriteLine("3) Gymnopedie No 1.");
            int input = 0;

            do
            {
                input = AskForInteger("Enter song number: ");

                switch (input)
                {
                    case 1:
                        Console.WriteLine($"Elapsed time: {SpeelYouAreMySunshine():F2}.");
                        break;
                    case 2:
                        Console.Write($"Elapsed time: {SpeelMarchOfTheToySoldiers():F2}.");
                        break;
                    case 3:
                        Console.Write($"Elapsed time: {SpeelGymnopedieOne(1000):F2}.");
                        break;
                    default:
                        input = 0;
                        break;
                }

            } while (input != 0);
        }

        static double SpeelYouAreMySunshine(int length = 500, int octave = 1)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();

            Re(length, octave);
            Sol(length, octave);
            La(length, octave);
            Si(length, octave);
            Si(length, octave);
            Si(length, octave);
            La(length, octave);
            Si(length, octave);
            Sol(length, octave);
            Sol(length, octave);


            Sol(length, octave);
            La(length, octave);
            Si(length, octave);
            Do2(length, octave);
            Mi(length, octave);
            Mi(length, octave);
            Re(length, octave);
            Do2(length, octave);
            Si(length, octave);

            stopwatch.Stop();
            return stopwatch.Elapsed.TotalSeconds;
        }

        static double SpeelMarchOfTheToySoldiers(int length = 500, int octave = 1)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();

            Do(length, octave);
            Do(length / 3, octave);
            Do(length / 3, octave);
            Do(length / 3, octave);
            Re(length, octave);
            Re(length, octave);
            Mi(length, octave);
            Do(length, octave);
            Re(length * 2, octave);

            Do(length, octave);
            Do(length / 3, octave);
            Do(length / 3, octave);
            Do(length / 3, octave);
            Re(length, octave);
            Re(length, octave);
            Mi(length, octave);
            Do(length, octave);
            Re(length * 2, octave);

            Si(length / 2, octave);
            Do2(length / 2, octave);
            Si(length / 2, octave);
            La(length / 2, octave);
            Sol(length / 2, octave);
            Fa(length / 2, octave);
            Mi(length / 2, octave);
            Do(length / 2, octave);

            La(length / 2, octave);
            Si(length / 2, octave);
            La(length / 2, octave);
            Sol(length / 2, octave);
            Fa(length / 2, octave);
            Mi(length / 2, octave);
            Re(length / 2, octave);
            Fa(length / 2, octave);

            stopwatch.Stop();
            return stopwatch.Elapsed.TotalSeconds;
        }

        static double SpeelGymnopedieOne(int length = 500, int octave = 1)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            
            La(length, octave);
            Do2(length, octave);
            Si(length, octave);
            La(length, octave);
            Mi(length, octave);
            Re(length, octave);
            Mi(length, octave);
            Fa(length, octave);
            Do(length, octave);

            stopwatch.Stop();
            return stopwatch.Elapsed.TotalSeconds;
        }

        static void Do(int length = 500, int octave = 1)
        {
            Console.Beep(264 * octave, length);
            WriteColoredText("Do", ConsoleColor.DarkGray);
        }

        static void Re(int length = 500, int octave = 1)
        {
            Console.Beep(297 * octave, length);
            WriteColoredText("Re", ConsoleColor.Gray);
        }

        static void Mi(int length = 500, int octave = 1)
        {
            Console.Beep(330 * octave, length);
            WriteColoredText("Mi", ConsoleColor.White);
        }

        static void Fa(int length = 500, int octave = 1)
        {
            Console.Beep(352 * octave, length);
            WriteColoredText("Fa", ConsoleColor.Yellow);
        }

        static void Sol(int length = 500, int octave = 1)
        {
            Console.Beep(396 * octave, length);
            WriteColoredText("Sol", ConsoleColor.Red);
        }

        static void La(int length = 500, int octave = 1)
        {
            Console.Beep(440 * octave, length);
            WriteColoredText("La", ConsoleColor.Cyan);
        }

        static void Si(int length = 500, int octave = 1)
        {
            Console.Beep(495 * octave, length);
            WriteColoredText("Si", ConsoleColor.Blue);
        }

        static void Do2(int length = 500, int octave = 1)
        {
            Console.Beep(528 * octave, length);
            WriteColoredText("Do2", ConsoleColor.DarkBlue);
        }


        static void WriteColoredText(string text, ConsoleColor foreGround = ConsoleColor.White, ConsoleColor backGround = ConsoleColor.Black, bool resetAfter = true)
        {
            Console.ForegroundColor = foreGround;
            Console.BackgroundColor = backGround;
            Console.WriteLine(text);

            if(resetAfter)
            {
                Console.ResetColor();
            }
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
