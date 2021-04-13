using System;

namespace Opwarmers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = VraagOmNummer("Geef een nummer: ");

            Console.WriteLine("Kwadraat: ");
            Console.WriteLine(Kwadraat(number));

            Console.WriteLine("Straal: ");
            Console.WriteLine(BerekenStraal(number));

            Console.WriteLine("Omtrek: ");
            Console.WriteLine(BerekenOmtrek(number));

            Console.WriteLine("Oppervlak: ");
            Console.WriteLine(BerekenOppervlakte(number));

            double numberOne = VraagOmNummer("Geef een nummer: ");
            double numberTwo = VraagOmNummer("Geef een tweede nummer: ");

            Console.WriteLine("Het grootste is: ");
            Console.WriteLine(Grootste(numberOne, numberTwo));

            int iNumber = (int)VraagOmNummer("Geef een integer: ");

            Console.WriteLine("Is het een Armstrong getal: ");
            Console.WriteLine(IsArmstrong(iNumber));

            Console.WriteLine("Alle oneven nummers tot dan: ");
            ToonOnevenNummers(iNumber);

            Console.WriteLine("Alle Armstrong nummers tot dan: ");
            ToonArmstrongNummers(iNumber);
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

        static double Kwadraat(double number)
        {
            return Math.Pow(number, 2);
        }

        static double BerekenStraal(double diameter)
        {
            return diameter / 2.0;
        }

        static double BerekenOmtrek(double diameter)
        {
            return diameter * Math.PI;
        }

        static double BerekenOppervlakte(double diameter)
        {
            return Kwadraat(BerekenStraal(diameter)) * Math.PI;
        }

        static double Grootste(double numberOne, double numberTwo)
        {
            if(numberOne >= numberTwo)
            {
                return numberOne;
            }
            else
            {
                return numberTwo;
            }
        }

        static bool IsEven(int getal)
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

        static bool IsArmstrong(int number)
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

        static void ToonOnevenNummers(int number)
        {
            for (int i = 1; i < number; i++)
            {
                if(i%2 != 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }

        static void ToonArmstrongNummers(int number)
        {
            for (int i = 0; i < number; i++)
            {
                if(IsArmstrong(i))
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}
