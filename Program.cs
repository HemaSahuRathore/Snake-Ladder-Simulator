namespace D4_SnakeNLadderSimulator
{ /// <summary>
  /// UC3 : Player checks for a Options : No Play, Ladder or Snake.
  /// </summary>
    public class Program
    {
        //Entrypoint of console app
        static void Main(string[] args)
        {   //constant variable
            const int START_POSITION = 0;

            Console.WriteLine("Welcome to the Snake and Ladder Simulator Program");
            Console.WriteLine("\nThe Position of your TOKEN in the board is START : " + START_POSITION);

            Random random = new Random(); //Creating Random class object to access Next function

            int dieRollNum = random.Next(1, 7); //using next function to generate number between 1 & 6
            Console.WriteLine("After Rolling die, Dice Number : " + dieRollNum);

            //Random function to generate options between 1 & 3
            int option = random.Next(1, 3);

            //Creating object of CheckOption to access CheckPlayOption method
            CheckOptions checkOptionObj = new CheckOptions();
            checkOptionObj.CheckOptionsNMove(option, dieRollNum);


        }

    }
}