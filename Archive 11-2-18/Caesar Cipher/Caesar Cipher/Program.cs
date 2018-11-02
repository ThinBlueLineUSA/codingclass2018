using System;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            int Again;
            do
            {
                Console.WriteLine("\n****************************************************************************");
                Console.WriteLine("** Welcome to the super amazing encryption/decryption machine!");
                Console.WriteLine("** Select the process you want to initiate:");
                Console.WriteLine("** 1. Encrypt a message");
                Console.WriteLine("** 2. Decrypt a message with a known key");
                Console.WriteLine("** 3. Force decrypt a message with an unknown key (lists all possibilities)");
                Console.WriteLine("** 4. Exit program");
                Console.WriteLine("****************************************************************************\n");
                Console.Write("Process: ");
                Again = int.Parse(Console.ReadLine());

                if (Again == 1)
                {
                    Encrypt();
                }
                else if (Again == 2)
                {
                    Decrypt();
                }
                else if (Again == 3)
                {
                    Force();
                }
            } while (Again != 4);
        }
        static void Encrypt()
        {
            string toShift;
            int shiftby;
            Console.WriteLine("\nEnter the message you want encrypted:");
            toShift = Console.ReadLine();
            Console.Write("\nEnter the key value you would like (any num from -26 to 26): ");
            shiftby = int.Parse(Console.ReadLine());
            Console.WriteLine("\nYour encrypted message is:");
            for (int i = 0; i < toShift.Length; i++)
            {
                char letter = toShift[i];
                int letternum = toShift[i];
                char newletter;
                int newletternum;
                if (letternum > 64 && letternum < 91)
                {
                    newletternum = (letter + shiftby);
                    if (newletternum < 65)
                    {
                        newletternum += 25;
                    }
                    else if (newletternum > 90)
                    {
                        newletternum -= 25;
                    }
                    newletter = (char)newletternum;
                    Console.Write(newletter);
                }
                else if (letternum > 96 && letternum < 123)
                {
                    newletternum = (letter + shiftby);
                    if (newletternum < 97)
                    {
                        newletternum += 25;
                    }
                    else if (newletternum > 122)
                    {
                        newletternum -= 25;
                    }
                    newletter = (char)newletternum;
                    Console.Write(newletter);
                }
                else if (letternum > 47 && letternum < 58)
                {
                    newletternum = (letter + shiftby);
                    if (newletternum < 48)
                    {
                        while (newletternum < 48)
                        {
                            newletternum += 10;
                        }
                    }
                    else if (newletternum > 57)
                    {
                        while (newletternum > 57)
                        {
                            newletternum -= 10;
                        }
                    }
                    newletter = (char)newletternum;
                    Console.Write(newletter);
                }
                else
                {
                    Console.Write(letter);
                }
            }
            Console.WriteLine();
        }
        static void Decrypt()
        {
            string toShift;
            int shiftby;
            Console.WriteLine("\nEnter the message you want decrypted:");
            toShift = Console.ReadLine();
            Console.Write("\nEnter your security key: ");
            shiftby = int.Parse(Console.ReadLine());
            Console.WriteLine("\nYour decrypted message is:");
            for (int i = 0; i < toShift.Length; i++)
            {
                char letter = toShift[i];
                int letternum = toShift[i];
                char newletter;
                int newletternum;
                if (letternum > 64 && letternum < 91)
                {
                    newletternum = (letter - shiftby);
                    if (newletternum < 65)
                    {
                        newletternum += 25;
                    }
                    else if (newletternum > 90)
                    {
                        newletternum -= 25;
                    }
                    newletter = (char)newletternum;
                    Console.Write(newletter);
                }
                else if (letternum > 96 && letternum < 123)
                {
                    newletternum = (letter - shiftby);
                    if (newletternum < 97)
                    {
                        newletternum += 25;
                    }
                    else if (newletternum > 122)
                    {
                        newletternum -= 25;
                    }
                    newletter = (char)newletternum;
                    Console.Write(newletter);
                }
                else if (letternum > 47 && letternum < 58)
                {
                    newletternum = (letter - shiftby);
                    if (newletternum < 48)
                    {
                        while (newletternum < 48)
                        {
                            newletternum += 10;
                        }
                    }
                    else if (newletternum > 57)
                    {
                        while (newletternum > 57)
                        {
                            newletternum -= 10;
                        }
                    }
                    newletter = (char)newletternum;
                    Console.Write(newletter);
                }
                else
                {
                    Console.Write(letter);
                }
            }
            Console.WriteLine();
        }
        static void Force()
        {
            string toShift;
            int shiftby;
            Console.WriteLine("\nEnter the message you want decrypted by force:");
            toShift = Console.ReadLine();
            Console.WriteLine("\nAll possible decryptions:");
            for (int i = 0; i < 25; i++)
            {
                shiftby = i;
                for (int j = 0; j < toShift.Length; j++)
                {
                    char letter = toShift[j];
                    int letternum = toShift[j];
                    char newletter;
                    int newletternum;
                    if (letternum > 64 && letternum < 91)
                    {
                        newletternum = (letter - shiftby);
                        if (newletternum < 65)
                        {
                            newletternum += 25;
                        }
                        else if (newletternum > 90)
                        {
                            newletternum -= 25;
                        }
                        newletter = (char)newletternum;
                        Console.Write(newletter);
                    }
                    else if (letternum > 96 && letternum < 123)
                    {
                        newletternum = (letter - shiftby);
                        if (newletternum < 97)
                        {
                            newletternum += 25;
                        }
                        else if (newletternum > 122)
                        {
                            newletternum -= 25;
                        }
                        newletter = (char)newletternum;
                        Console.Write(newletter);
                    }
                    else if (letternum > 47 && letternum < 58)
                    {
                        newletternum = (letter - shiftby);
                        if (newletternum < 48)
                        {
                            while (newletternum < 48)
                            {
                                newletternum += 10;
                            }
                        }
                        else if (newletternum > 57)
                        {
                            while (newletternum > 57)
                            {
                                newletternum -= 10;
                            }
                        }
                        newletter = (char)newletternum;
                        Console.Write(newletter);
                    }
                    else
                    {
                        Console.Write(letter);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
