namespace D4_SnakeNLadderSimulator
{ /// <summary>
  /// UC5 : Ensure the player gets to exact winning position 100. 
  /// In case the player position go above 100, player stays in the same previous position till the player gets the exact
  /// </summary>
    public class Program
    {
        //Entrypoint of console app
        static void Main(string[] args)
        {
            int position = 0;

            //constant variable
            const int START_POSITION = 0;
            const int WINNING_POSITION = 100;

            Console.WriteLine("Welcome to the Snake and Ladder Simulator Program");
            Console.WriteLine("\nThe Position of your TOKEN in the board is START : " + START_POSITION);

            Random random = new Random(); //Creating Random class object to access Next function

            while (position != WINNING_POSITION)
            {
                int dieRollNum = random.Next(1, 7); //using next function to generate number between 1 & 6
                Console.WriteLine("\nAfter Rolling die, Dice Number : " + dieRollNum);

                int option = random.Next(1, 4); //Random function to generate options between 1 & 3
                
                ReturnPosition returnPositionObj = new ReturnPosition(); //Creating object of ReturnPosition class to access ReturnCurrentPosition method
                position = returnPositionObj.ReturnCurrentPosition(option, dieRollNum, position); //storing current position to run the loop

            }

        }

    }
}