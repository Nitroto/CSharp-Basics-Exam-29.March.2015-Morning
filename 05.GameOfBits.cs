using System;
using System.Globalization;
using System.Threading;

class GameOfBits
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        uint number = uint.Parse(Console.ReadLine());
        string command = Console.ReadLine();
        while (command != "Game Over!")
        {

            if (command == "Odd")
            {
                number = ChangeBit(number, 1);
            }
            else
            {
                number = ChangeBit(number, 0);
            }
            command = Console.ReadLine();
        }
        uint bitCount = CountBits(number);
        Console.WriteLine("{0} -> {1}", number, bitCount);
    }

    private static uint CountBits(uint number)
    {
        uint bitCounter = 0u;
        for (int i = 0; i <= 31; i++)
        {
            bitCounter += ((number >> i) & 1);
        }

        return bitCounter;
    }

    private static uint ChangeBit(uint number, int oneOrZero)
    {
        uint newNumber = 0u;
        for (int bit = 32; bit >= 1; bit--)
        {
            if ((bit & 1) == oneOrZero)
            {
                int realBit = bit - 1;
                newNumber <<= 1;
                uint bitValue = (number >> realBit) & 1u;
                newNumber |= bitValue;
            }
        }

        return newNumber;
    }
}
