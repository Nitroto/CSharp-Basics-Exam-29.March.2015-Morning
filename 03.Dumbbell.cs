using System;
using System.Globalization;
using System.Threading;

class Dumbbell
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int midSpaces = n / 2;
        int spacesBefore = n / 2;
        bool midPoint = true;
        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == n - 1)
            {
                Console.Write(new string('.', spacesBefore));
                Console.Write(new string('&', ((n / 2) + 1)));
                Console.Write(new string('.', (n)));
                Console.Write(new string('&', ((n / 2) + 1)));
                Console.Write(new string('.', spacesBefore));
                spacesBefore--;
                Console.WriteLine();
            }
            else
            {
                Console.Write(new string('.', spacesBefore));
                Console.Write('&');
                Console.Write(new string('*',midSpaces));
                Console.Write('&');
                if (spacesBefore != 0)
                {
                    Console.Write(new string('.', (n)));
                }
                else
                {
                    Console.Write(new string('=', (n)));
                }
                Console.Write('&');
                Console.Write(new string('*', midSpaces));
                Console.Write('&');
                Console.Write(new string('.', spacesBefore));
                if (spacesBefore > 0 && midPoint)
                {
                    spacesBefore--;
                    midSpaces++;
                }
                else
                {
                    midPoint = false;
                    spacesBefore++;
                    midSpaces--;
                }
                Console.WriteLine();
            }
        }
    }
}
