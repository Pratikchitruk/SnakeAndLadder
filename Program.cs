
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankeLader
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to snake and ladder game");
            RollADice.RollingTheDice();

             string square = SnkeAndLadder.PlayerCheck.ThePlayerIsChecking();
            Console.WriteLine("The sqare is" + square );
            WiningPlayer.ThePlayerIsWining();
           



        }
    }
}