namespace D4_SnakeNLadderSimulator
{ /// <summary>
  /// UC7 : Play the game with 2 Player. In this case if a Player gets a Ladder then plays again.
  /// Finally report which Player won the game
  /// </summary>
    public class Program
    {
        //Entrypoint of console app
        static void Main(string[] args)
        {   //local variables
            int player1Position = 0;
            int player2Position = 0;
            int diceRollCount = 0;

            //constant variable
            const int START_POSITION = 0;
            const int WINNING_POSITION = 100;

            Console.WriteLine("Welcome to the Snake and Ladder Simulator Program");
            Console.WriteLine("Mode : Two Player");
            Console.WriteLine("\nThe Position of both the TOKEN in the board is START : " + START_POSITION);

            Random random = new Random();

            while (player1Position != WINNING_POSITION && player2Position != WINNING_POSITION)
            {
                int dieRollNum = random.Next(1, 7);
                diceRollCount++; //increasing dice roll count everytime die rolled to pass the die to next player
                Console.WriteLine("\nAfter Rolling die, Dice Number : " + dieRollNum);

                if (diceRollCount % 2 == 1)
                {
                    int option = random.Next(1, 4);
                    if (option == 2) //option 2 = Ladder
                    {
                        diceRollCount -= 1; //decrement dice roll count by -1 to repeat the player turn
                    }
                    Console.WriteLine("Player 1");
                    ReturnPosition returnPositionObj = new ReturnPosition();
                    player1Position = returnPositionObj.ReturnCurrentPosition(option, dieRollNum, player1Position);
                    if (player1Position == WINNING_POSITION) //checks if Player 1 reached 100
                        Console.WriteLine("\nPlayer 1 won the Game");
                }
                else
                {
                    int option = random.Next(1, 4);
                    if (option == 2)//option 2 = Ladder
                        diceRollCount -= 1; //decrement dice roll count by -1 to repeat the player turn(Player plays again)

                    Console.WriteLine("Player 2");
                    ReturnPosition returnPositionObj = new ReturnPosition();
                    player2Position = returnPositionObj.ReturnCurrentPosition(option, dieRollNum, player2Position);
                    if (player2Position == WINNING_POSITION) //checks if Player 1 reached 100
                        Console.WriteLine("\nPlayer 2 won the game");

                }

            }

        }

    }
}