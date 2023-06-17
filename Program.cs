using System;

namespace vArise
{
    class Week1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the points required to qualify: ");
            int Point = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of matches: ");
            int Match = Convert.ToInt32(Console.ReadLine());

            int Win = 2;
            int Tie = 1;
            int Loss = 0;

            int MaxPoints = Match * Win;
            int MinWins = (Point - (Match * Tie)) / Win;

            Console.WriteLine("The team needs a minimum of {0} wins to qualify.", MinWins);

            Console.ReadLine();
        }
    }
}
