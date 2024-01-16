using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephToyRobot
{
    public class Robot
    {
        public int x, y;
        public Direction direction = Direction.North;

        // X, Y, Facing
        public Robot(int x, int y, char f) {
            this.x = x;
            this.y = y;
            switch(f)
            {
                case 'N':
                    this.direction = Direction.North;
                    break;
                case 'E':
                    this.direction = Direction.East;
                    break;
                case 'S':
                    this.direction = Direction.South;
                    break;
                case 'W':
                    this.direction = Direction.West;
                    break;
            }
        }

        // Magic numbers should be removed, another function should handle checking if the destination is possible
        public void Move() { 
            switch(direction)
            {
                case Direction.North:
                    y++;
                    if (y > 5)
                    {
                        y = 5;
                    }
                    break;
                case Direction.East:
                    x++;
                    if (x > 5)
                    {
                        x = 5;
                    }
                    break;
                case Direction.South:
                    y--;
                    if (y < 0)
                    {
                        y = 0;
                    }
                    break;
                case Direction.West:
                    x--;
                    if (x < 0)
                    {
                        x = 0;
                    }
                    break;
            }

        }

        public void TurnRight()
        {
            if(direction == Direction.West)
            {
                direction = Direction.North;
            }
            else
            {
                direction++;
            }
        }

        public void TurnLeft()
        {
            if (direction == Direction.North)
            {
                direction = Direction.West;
            }
            else
            {
                direction--;
            }

        }
    }
}
