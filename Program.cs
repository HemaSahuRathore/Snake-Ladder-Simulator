namespace D4_SnakeNLadderSimulator
{ /// <summary>
  /// UC1 : Snake and Ladder game played with single player at start position 0 
  /// </summary>
    public class Program
    {
        //Entrypoint of console app
        static void Main(string[] args)
        {   //constant variable
            const int START_POSITION = 0; //start position remains same for each player

            Console.WriteLine("Welcome to the Snake and Ladder Simulator Program");
            Console.WriteLine("\nThe Position of your TOKEN in the board is START : " + START_POSITION); //displaying start position
            Console.ReadLine();
        }
    }
}