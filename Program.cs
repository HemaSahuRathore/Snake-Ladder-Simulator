namespace D4_SnakeNLadderSimulator
{ /// <summary>
  /// UC6 : Report the number of times the dice was played to win the game and also the position after every die role
  /// </summary>
    public class Program
    {
        //Entrypoint of console app
        static void Main(string[] args)
        {   //Local Variables
            int position = 0;
            int dieRollCount = 0;

            //constant variables
            const int START_POSITION = 0;
            const int WINNING_POSITION = 100;

            Console.WriteLine("Welcome to the Snake and Ladder Simulator Program");
            Console.WriteLine("\nThe Position of your TOKEN in the board is START : " + START_POSITION);

            Random random = new Random(); //Creating Random class object to access Next function

            while (position != WINNING_POSITION)
            {
                int dieRollNum = random.Next(1, 7);
                dieRollCount++; //incrementing dieRollCount everytime die roll to get num. of times Die rolled
                Console.WriteLine("\nAfter Rolling die, Dice Number : " + dieRollNum);

                int option = random.Next(1, 4);

                //Creating object of ReturnPosition class 
                ReturnPosition returnPositionObj = new ReturnPosition();
                position = returnPositionObj.ReturnCurrentPosition(option, dieRollNum, position); //storing current position to run the  while loop

                //Printing Die count once player reaches 100
                if (position == WINNING_POSITION)
                    Console.WriteLine("\nThe number of times Die rolled to Win the Game : " + dieRollCount);
            }

        }

    }
}