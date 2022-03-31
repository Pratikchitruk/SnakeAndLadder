namespace SnkeAndLadder
{
    public class playerCheckBase
    {
        public static string ThePlayerIsChecking()
        {
            int snake = 0;
            int ladder = 0;

            Random rand = new Random();
            int dice = rand.Next(7);

            Console.WriteLine("no. is :" + dice);

            string[] square = { " NO MOVE", "GO AHEAD", "CLIMB LADDER", "GO AHEAD", "GO AHEAD", "DOWN BY SNAKE", "GO AHEAD", "GO HEAD", };

            return square[dice];
        }
    }
}