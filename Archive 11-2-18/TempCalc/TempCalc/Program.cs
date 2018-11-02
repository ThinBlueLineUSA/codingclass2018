using System;

public class Program
{
    public static void Main()
    {
        char Again = 'y';
        do
        {
            Console.WriteLine("\tTemperature units:\t\n - - - - - - - - - - - - - - -\n   Fahrenheit-" +
                 "\t\t   f  \n   Celsius-\t\t   c  \n   Kelvin-\t\t   k  \n   Rankine-\t\t   a" +
                 "  \n   Rømer-\t\t   o  \n   Newton-\t\t   n  \n   Delisle-\t\t   d  \n   Réaumur-" +
                 "\t\t   e  \n");

            char Input;
            char Output;
            double num;
            Console.WriteLine("Enter known temperature value: ");
            num = Convert.ToDouble(Console.ReadLine());

            char f = 'f';
            char c = 'c';
            char k = 'k';
            char a = 'a';
            char o = 'o';
            char n = 'n';
            char d = 'd';
            char e = 'e';
            double FTF = num;
            double CTC = num;
            double KTK = num;
            double ATA = num;
            double OTO = num;
            double NTN = num;
            double DTD = num;
            double ETE = num;
            double FTC = (num - 32.0) * 5.0 / 9.0;
            double FTK = (num - 32.0) * 5.0 / 9.0 + 273.15;
            double FTA = (num + 459.67);
            double FTO = (num - 32.0) * 7.0 / 24.0 + 7.5;
            double FTN = (num - 32.0) * 11.0 / 60.0;
            double FTD = (212 - num) * 5.0 / 6.0;
            double FTE = (num - 32.0) * 4.0 / 9.0;
            double CTF = (num * 9.0) / 5.0 + 32.0;
            double CTK = (num + 273.15);
            double CTA = (num + 273.15) * 9.0 / 5.0;
            double CTO = (num * 21.0) / 40.0 + 7.5;
            double CTN = (num * 33.0) / 100.0;
            double CTD = (100.0 - num) * 3.0 / 2.0;
            double CTE = (num * 4.0) / 5.0;
            double KTF = (num - 273.15) * 9.0 / 5.0 + 32.0;
            double KTC = (num - 273.15);
            double KTA = (num * 9.0) / 5.0;
            double KTO = (num - 273.15) * 21.0 / 40.0 + 7.5;
            double KTN = (num - 273.15) * 33.0 / 100.0;
            double KTD = (373.15 - num) * 3.0 / 2.0;
            double KTE = (num - 273.15) * 4.0 / 5.0;
            double ATF = (num - 459.67);
            double ATC = (num - 491.67) * 5.0 / 9.0;
            double ATK = (num * 5.0) / 9.0;
            double ATO = (num - 491.67) * 7.0 / 24.0 + 7.5;
            double ATN = (num - 491.67) * 11.0 / 60.0;
            double ATD = (671.67 - num) * 5.0 / 6.0;
            double ATE = (num - 491.67) * 4.0 * 9.0;
            double OTF = (num - 7.5) * 24.0 / 7.0 + 32.0;
            double OTC = (num - 7.5) * 40.0 / 21.0;
            double OTK = (num - 7.5) * 40.0 / 21.0 + 273.15;
            double OTA = (num - 7.5) * 24.0 / 7.0 + 491.67;
            double OTN = (num - 7.5) * 22.0 / 35.0;
            double OTD = (60 - num) * 20.0 / 7.0;
            double OTE = (num - 7.5) * 32.0 / 21.0;
            double NTF = (num * 60.0) / 11.0 + 32.0;
            double NTC = (num * 100.0) / 32.0;
            double NTK = (num * 100.0) / 33.0 + 273.15;
            double NTA = (num * 60.0) / 11.0 + 491.67;
            double NTO = (num * 35.0) / 22.0 + 7.5;
            double NTD = (33.0 - num) * 50.0 / 11.0;
            double NTE = (num * 80.0) / 33.0;
            double DTF = (212.0 - num) * 6.0 / 5.0;
            double DTC = (100.0 - num) * 2.0 / 3.0;
            double DTK = 373.15 - (num * 2.0 / 3.0);
            double DTA = (671.67 - num) * 6.0 / 5.0;
            double DTO = (60.0 - num) * 7.0 / 20.0;
            double DTN = (33.0 - num) * 11.0 / 50.0;
            double DTE = (80.0 - num) * 8.0 / 15.0;
            double ETF = (num * 9.0) / 4.0 + 32.0;
            double ETC = (num * 5.0) / 4.0;
            double ETK = (num * 5.0) / 4.0 + 273.15;
            double ETA = (num * 9.0) / 4.0 + 491.67;
            double ETO = (num * 21.0) / 32.0 + 7.5;
            double ETN = (num * 33.0) / 80.0;
            double ETD = (80.0 - num) * 15.0 / 8.0;

            f = 'f';
            c = 'c';
            k = 'k';
            a = 'a';
            o = 'o';
            n = 'n';
            d = 'd';
            e = 'e';

            Console.WriteLine("Enter known temperature unit (Initial above): ");
            Input = Convert.ToChar(Console.ReadLine());
            if (Input == f)
            {
                Console.WriteLine("Enter desired temperature unit (Initial above): ");
                Output = Convert.ToChar(Console.ReadLine());
                if (Output == f)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Fahrenheit equals " + FTF + " degrees in Fahrenheit");
                }
                if (Output == c)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Fahrenheit equals " + FTC + " degrees in Celsius");
                }
                if (Output == k)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Fahrenheit equals " + FTK + " degrees in Kelvin");
                }
                if (Output == a)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Fahrenheit equals " + FTA + " degrees in Rankine");
                }
                if (Output == o)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Fahrenheit equals " + FTO + " degrees in Rømer");
                }
                if (Output == n)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Fahrenheit equals " + FTN + " degrees in Newton");
                }
                if (Output == d)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Fahrenheit equals " + FTD + " degrees in Delisle");
                }
                if (Output == e)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Fahrenheit equals " + FTE + " degrees in Réaumur");
                }
            }
            if (Input == c)
            {
                Console.WriteLine("Enter desired temperature unit (Initial above): ");
                Output = Convert.ToChar(Console.ReadLine());
                if (Output == c)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Celsius equals " + CTC + " degrees in Celsius");
                }
                if (Output == f)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Celsius equals " + CTF + " degrees in Fahrenheit");
                }
                if (Output == k)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Celsius equals " + CTK + " degrees in Kelvin");
                }
                if (Output == a)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Celsius equals " + CTA + " degrees in Rankine");
                }
                if (Output == o)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Celsius equals " + CTO + " degrees in Rømer");
                }
                if (Output == n)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Celsius equals " + CTN + " degrees in Newton");
                }
                if (Output == d)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Celsius equals " + CTD + " degrees in Delisle");
                }
                if (Output == e)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Celsius equals " + CTE + " degrees in Réaumur");
                }
            }
            if (Input == k)
            {
                Console.WriteLine("Enter desired temperature unit (Initial above): ");
                Output = Convert.ToChar(Console.ReadLine());
                if (Output == k)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Kelvin equals " + KTK + " degrees in Kelvin");
                }
                if (Output == f)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Kelvin equals " + KTF + " degrees in Fahrenheit");
                }
                if (Output == c)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Kelvin equals " + KTC + " degrees in Celsius");
                }
                if (Output == a)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Kelvin equals " + KTA + " degrees in Rankine");
                }
                if (Output == o)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Kelvin equals " + KTO + " degrees in Rømer");
                }
                if (Output == n)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Kelvin equals " + KTN + " degrees in Newton");
                }
                if (Output == d)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Kelvin equals " + KTD + " degrees in Delisle");
                }
                if (Output == e)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Kelvin equals " + KTE + " degrees in Réaumur");
                }
            }
            if (Input == a)
            {
                Console.WriteLine("Enter desired temperature unit (Initial above): ");
                Output = Convert.ToChar(Console.ReadLine());
                if (Output == a)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Rankine equals " + ATA + " degrees in Rankine");
                }
                if (Output == f)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Rankine equals " + ATF + " degrees in Fahrenheit");
                }
                if (Output == c)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Rankine equals " + ATC + " degrees in Celsius");
                }
                if (Output == k)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Rankine equals " + ATK + " degrees in Kelvin");
                }
                if (Output == o)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Rankine equals " + ATO + " degrees in Rømer");
                }
                if (Output == n)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Rankine equals " + ATN + " degrees in Newton");
                }
                if (Output == d)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Rankine equals " + ATD + " degrees in Delisle");
                }
                if (Output == e)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Rankine equals " + ATE + " degrees in Réaumur");
                }
            }
            if (Input == o)
            {
                Console.WriteLine("Enter desired temperature unit (Initial above): ");
                Output = Convert.ToChar(Console.ReadLine());
                if (Output == o)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Rømer equals " + OTO + " degrees in Rømer");
                }
                if (Output == f)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Rømer equals " + OTF + " degrees in Fahrenheit");
                }
                if (Output == c)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Rømer equals " + OTC + " degrees in Celsius");
                }
                if (Output == k)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Rømer equals " + OTK + " degrees in Kelvin");
                }
                if (Output == a)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Rømer equals " + OTA + " degrees in Rankine");
                }
                if (Output == n)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Rømer equals " + OTN + " degrees in Newton");
                }
                if (Output == d)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Rømer equals " + OTD + " degrees in Delisle");
                }
                if (Output == e)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Rømer equals " + OTE + " degrees in Réaumur");
                }
            }
            if (Input == n)
            {
                Console.WriteLine("Enter desired temperature unit (Initial above): ");
                Output = Convert.ToChar(Console.ReadLine());
                if (Output == n)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Newton equals " + NTN + " degrees in Newton");
                }
                if (Output == f)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Newton equals " + NTF + " degrees in Fahrenheit");
                }
                if (Output == c)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Newton equals " + NTC + " degrees in Celsius");
                }
                if (Output == k)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Newton equals " + NTK + " degrees in Kelvin");
                }
                if (Output == a)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Newton equals " + NTA + " degrees in Rankine");
                }
                if (Output == o)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Newton equals " + NTO + " degrees in Rømer");
                }
                if (Output == d)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Newton equals " + NTD + " degrees in Delisle");
                }
                if (Output == e)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Newton equals " + NTE + " degrees in Réaumur");
                }
            }
            if (Input == d)
            {
                Console.WriteLine("Enter desired temperature unit (Initial above): ");
                Output = Convert.ToChar(Console.ReadLine());
                if (Output == d)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Delisle equals " + DTD + " degrees in Delisle");
                }
                if (Output == f)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Delisle equals " + DTF + " degrees in Fahrenheit");
                }
                if (Output == c)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Delisle equals " + DTC + " degrees in Celsius");
                }
                if (Output == k)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Delisle equals " + DTK + " degrees in Kelvin");
                }
                if (Output == a)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Delisle equals " + DTA + " degrees in Rankine");
                }
                if (Output == o)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Delisle equals " + DTO + " degrees in Rømer");
                }
                if (Output == n)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Delisle equals " + DTN + " degrees in Newton");
                }
                if (Output == e)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Delisle equals " + DTE + " degrees in Réaumur");
                }
            }
            if (Input == e)
            {
                Console.WriteLine("Enter desired temperature unit (Initial above): ");
                Output = Convert.ToChar(Console.ReadLine());
                if (Output == e)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Réaumur equals " + ETE + " degrees in Réaumur");
                }
                if (Output == f)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Réaumur equals " + ETF + " degrees in Fahrenheit");
                }
                if (Output == c)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Réaumur equals " + ETC + " degrees in Celsius");
                }
                if (Output == k)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Réaumur equals " + ETK + " degrees in Kelvin");
                }
                if (Output == a)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Réaumur equals " + ETA + " degrees in Rankine");
                }
                if (Output == o)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Réaumur equals " + ETO + " degrees in Rømer");
                }
                if (Output == n)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Réaumur equals " + ETN + " degrees in Newton");
                }
                if (Output == d)
                {
                    Console.WriteLine("\n\n\n" + num + " degrees in Réaumur equals " + ETD + " degrees in Delisle");
                }
            }
            Console.WriteLine("\nWould you like to convert another temperature? (y/n): ");
            Again = Convert.ToChar(Console.ReadLine());
        } while (Again == 'y');
    }
}