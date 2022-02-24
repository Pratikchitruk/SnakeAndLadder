using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankeLader
{
    public class RollADice
    {
        public static void RollingTheDice()
        {


            Random rand = new Random();
            int dice = rand.Next(1, 6);

            Console.WriteLine("no. is :" + dice);





        }
    }
}
