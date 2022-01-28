using Football_Betting.Data;
using System;

namespace Football_Betting
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new FootballBettingContext();
            context.Database.EnsureCreated();
        }
    }
}
