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
        public int ReturnCurrentPosition(int option, int dieRoll, int position)
        {
            //Selection statement to select option and change position accordingly
            switch (option)
            {
                case 1: //No Play
                    Console.WriteLine("Option : No Play");
                    position = position;
                    Console.WriteLine("Your Current Position : " + position);
                    break;
                case 2: //Ladder
                    Console.WriteLine("Option : Ladder");
                    position += dieRoll;
                    Console.WriteLine("Your Current Position : " + position);
                    break;
                default: //Snake
                    Console.WriteLine("Option : Snake");
                    position -= dieRoll;
                    if (position < 0) //if position becomes less than 0, player restarts from START i.e 0
                    { position = 0; }
                    Console.WriteLine("Your Current Position : " + position);
                    break;
            }
            return position;

        }
    }
}