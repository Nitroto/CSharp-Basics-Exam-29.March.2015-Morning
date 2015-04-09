using System;
using System.Globalization;
using System.Threading;

class BasketBattle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string player = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        int simeonScore = 0;
        int nakovScore = 0;
        int endRound = 0;
        bool makePoints = false;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                int p = int.Parse(Console.ReadLine());
                string info = Console.ReadLine();
                p = info == "success" ? p : 0;
                switch (player)
                {
                    case "Nakov":if (nakovScore + p <= 500)
                        {
                            nakovScore += p;
                        }
                        break;
                    case "Simeon":
                        if (simeonScore + p <= 500)
                        {
                            simeonScore += p;
                        }
                        break;
                }
                if (nakovScore == 500 || simeonScore == 500)
                {
                    makePoints = true;
                    endRound = i + 1;
                    break;
                }
                player = player == "Simeon" ? "Nakov" : "Simeon";

            }
            player = player == "Simeon" ? "Nakov" : "Simeon";
            if (makePoints)
            {
                break;
            }
        }
        string winner = simeonScore > nakovScore ? "Simeon" : "Nakov";
        if (makePoints)
        {
            Console.WriteLine("{0}\r\n{1}\r\n{2}", winner, endRound, Math.Min(simeonScore, nakovScore));
        }
        else if (simeonScore != nakovScore)
        {
            Console.WriteLine("{0}\r\n{1}", winner, Math.Abs(simeonScore - nakovScore));
        }
        else if (simeonScore == nakovScore)
        {
            Console.WriteLine("DRAW\r\n{0}", nakovScore);
        }
    }
}
