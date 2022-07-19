using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_SnakeNLadderSimulator
{
    public class ReturnPosition
    {
        //Method to match option, move token accordingly and return current position
        public int ReturnCurrentPosition(int option, int dieRollNum, int position)

        {   //Selection statement to select option and change position accordingly
            switch (option)
            {
                case 1: //For Option : No Play
                    Console.WriteLine("Option : No Play");
                    position = position;
                    Console.WriteLine("Your TOKEN Position in the board : " + position);
                    break;

                case 2: // For Option : Ladder
                    Console.WriteLine("Option : Ladder");
                    position += dieRollNum;

                    if (position > 100) // checking if player gets the position > 100
                        position -= dieRollNum; //if yes, subtracting position from dice number to get the previous position

                    Console.WriteLine("Your TOKEN Position in the board : " + position);

                    break;

                default:  // For Option : Snake
                    Console.WriteLine("Option : Snake");
                    position -= dieRollNum;

                    if (position < 0) //if position becomes less than 0, player restarts from START i.e 0
                        position = 0;

                    Console.WriteLine("Your TOKEN Position in the board : " + position);
                    break;
            }

            return position; //returning current position

        }
    }
}