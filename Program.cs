namespace D4_SnakeNLadderSimulator
{ /// <summary>
  /// UC2 : The Player rolls the die to get a number between 1 to 6
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

        }
    }
}