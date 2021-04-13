using System;

namespace DeBasis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro
            MyIntro();
            Console.WriteLine();
            MyIntro("Matthijs Debacker", 25, "SomewhereStraat 28");
            Console.WriteLine();

            // Grootste
            double one = VraagOmNummer("Nummer 1: ");
            double two = VraagOmNummer("Nummer 2: ");
            double three = VraagOmNummer("Nummer 3: ");
            Console.WriteLine($"Het grootste getal tussen {one}, {two} en {three} is:");
            Console.WriteLine(Grootste(one, two, three));
            Console.WriteLine();

            // Passwoord
            int lengte = (int)VraagOmNummer("Hoe lang moet uw passwoord zijn:");
            Console.Write(PaswoordGenerator(lengte));

            // Rekenmachine
        }

        static double VraagOmNummer(string vraag)
        {
            Console.WriteLine(vraag);
            double iNumber = 0;

            string sNumber = Console.ReadLine();
            while (!double.TryParse(sNumber, out iNumber))
            {
                Console.Clear();
                Console.WriteLine("Foutief nummer, probeer opnieuw.");
                sNumber = Console.ReadLine();
            }
            return iNumber;
        }

        static void MyIntro()
        {
            Console.WriteLine("Ik ben Matthijs Debacker, ik ben 25 jaar oud en woon in de SomewhereStraat 28.");
        }

        static void MyIntro(string name, int age, string adress)
        {
            Console.WriteLine($"Ik ben {name}, ik ben {age} jaar oud en ik woon in de {adress}.");
        }

        static double Grootste(double one, double two, double three)
        {
            return Math.Max(one, Math.Max(two, three));
        }

        static double TelOp(double one, double two)
        {
            return one + two;
        }

        static double TrekAf(double one, double two)
        {
            return one - two;
        }

        static double Vermenigvuldig(double one, double two)
        {
            return one * two;
        }

        static double Deel(double one, double two)
        {
            return one / two;
        }

        static double Macht(double number, int pow)
        {
            double result = number;
            for (int i = 0; i < pow; i++)
            {
                result *= number;
            }

            return result;
        }

        static string PaswoordGenerator(int length)
        {
            string password = "";
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                int r = rand.Next(0, 3);

                switch (r)
                {
                    case 0:
                        r = rand.Next(48, 58);
                        break;
                    case 1:
                        r = rand.Next(65, 91);
                        break;
                    case 2:
                        r = rand.Next(97, 123);
                        break;
                    default:
                        r = 48;
                        break;
                }

                password += Convert.ToChar(r);
            }

            return password;
        }
    }
}
