using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnkeAndLadder
{
    public class PlayerCheck
    {
        public static string  ThePlayerIsChecking()
        {   

            Random rand = new Random();
            int dice = rand.Next(7);

            Console.WriteLine("no. is :" + dice);

            string[] square = { " NO MOVE", "GO AHEAD", "CLIMB LADDER", "GO AHEAD", "GO AHEAD", "DOWN BY SNAKE", "GO AHEAD", "GO HEAD", };

            return square[dice];

            Console.WriteLine(" the sqare id display");
        }
       
    }
}

