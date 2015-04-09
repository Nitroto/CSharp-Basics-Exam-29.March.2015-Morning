using System;
using System.Globalization;
using System.Threading;

class TorrentPirate
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double d = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        double w = double.Parse(Console.ReadLine());
        double internetSpeed = 2;
        double moviesSize = 1500;
        double downloadTime = d / internetSpeed / 3600;
        double spendInMall = w * downloadTime;
        double movies = d / moviesSize;
        double spendInCinema = movies * p;
        if (spendInCinema < spendInMall)
        {
            Console.WriteLine("cinema -> {0:f2}lv", spendInCinema);
        }
        else
        {
            Console.WriteLine("mall -> {0:f2}lv", spendInMall);
        }
    }
}
