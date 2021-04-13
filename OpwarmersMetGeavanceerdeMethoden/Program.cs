using System;

namespace OpwarmersMetGeavanceerdeMethoden
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = VraagOmNummer("Geef een nummer: ");

            Console.WriteLine("Kwadraat: ");
            Console.WriteLine(Kwadraat(number: number));

            Console.WriteLine("Straal: ");
            Console.WriteLine(BerekenStraal(diameter: number));

            Console.WriteLine("Omtrek: ");
            Console.WriteLine(BerekenOmtrek(diameter: number));

            Console.WriteLine("Oppervlak: ");
            Console.WriteLine(BerekenOppervlakte(diameter: number));

            double numberOne = VraagOmNummer("Geef een nummer: ");
            double numberTwo = VraagOmNummer("Geef een tweede nummer: ");

            Console.WriteLine("Het grootste is: ");
            Console.WriteLine(Grootste(numberOne: numberOne, numberTwo));

            int iNumber = (int)VraagOmNummer("Geef een integer: ");

            Console.WriteLine("Is het een Armstrong getal: ");
            Console.WriteLine(IsArmstrong(number: iNumber));

            Console.WriteLine("Alle oneven nummers tot dan: ");
            ToonOnevenNummers(number: iNumber);

            Console.WriteLine("Alle Armstrong nummers tot dan: ");
            ToonArmstrongNummers(number: iNumber);
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

        static double Kwadraat(double number = 1)
        {
            return Math.Pow(number, 2);
        }

        static double BerekenStraal(double diameter = 20.0)
        {
            return diameter / 2.0;
        }

        static double BerekenOmtrek(double diameter = 20.0)
        {
            return diameter * Math.PI;
        }

        static double BerekenOppervlakte(double diameter = 20.0)
        {
            return Kwadraat(BerekenStraal(diameter)) * Math.PI;
        }

        static double Grootste(double numberOne, double numberTwo = 0)
        {
            if (numberOne >= numberTwo)
            {
                return numberOne;
            }
            else
            {
                return numberTwo;
            }
        }

        static bool IsEven(int getal = 10)
        {
            if (getal % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsArmstrong(int number = 10)
        {
            // Initialise required variables
            string sNumber = Convert.ToString(number);
            int currentNumber = number;
            int armstrongNumber = 0;

            // Loop through the number and perform armstrong calculations
            for (int i = 0; i < sNumber.Length; i++)
            {
                int multiplier = (int)Math.Pow(10, sNumber.Length - i - 1);
                int remainder = currentNumber / multiplier;
                currentNumber -= remainder * multiplier;
                armstrongNumber += (int)Math.Pow(remainder, sNumber.Length);
            }

            // Check with the initial number and respond accordingly
            if (number == armstrongNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void ToonOnevenNummers(int number = 10)
        {
            for (int i = 1; i < number; i++)
            {
                if (!IsEven(getal: i))
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }

        static void ToonArmstrongNummers(int number = 1000)
        {
            for (int i = 0; i < number; i++)
            {
                if (IsArmstrong(i))
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}
