using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephToyRobot
{
    public class Robot
    {
        private int maxY = 5;
        private int maxX = 5;
        private int minY = -1;
        private int minX = -1;

        // -1 to set invalid location by defualt
        public int X { get; set; } = -1;
        public int Y { get; set; } = -1;
        public Direction direction = Direction.NORTH;

        public Robot() {
        }
        public bool HasValidXY()
        {
            bool valid = true;

            if(X < minX || X > maxX || Y < minY || Y > maxY) {
                valid = false;
            }
            return valid;
        }

        // update Robots location.
        public void Place(int x, int y, char f)
        {
            switch (f)
            {
                case 'N':
                    this.direction = Direction.NORTH;
                    break;
                case 'E':
                    this.direction = Direction.EAST;
                    break;
                case 'S':
                    this.direction = Direction.SOUTH;
                    break;
                case 'W':
                    this.direction = Direction.WEST;
                    break;
                default:// invalid direction, 
                    return;
            }
            this.X = x;
            this.Y = y;
        }

        public string Report()
        {
            // if x/y not valid ignore input.
            if (!HasValidXY())
            {
                return null;
            }
            return X + "," + Y + "," + direction;
        }

        // will move the robot in the direction if it is inside the bounds
        public void Move()
        {
            // if x/y not valid ignore input.
            if (!HasValidXY())
            {
                return;
            }
            switch (direction)
            {
                case Direction.NORTH:
                    if (Y < maxY && Y > minY)
                    {
                        Y++;
                    }
                    break;
                case Direction.EAST:
                    if (X < maxX && X > minX)
                    {
                        X++;
                    }
                    break;
                case Direction.SOUTH:
                    if (Y < maxY && Y > minY)
                    {
                        Y--;
                    }
                    break;
                case Direction.WEST:
                    if (X < maxX && X > minX)
                    {
                        X--;
                    }
                    break;
            }

        }

        // Direction can be increased by 1 or decreased by 1 to change the direction in order of N,E,S,W thanks to Enum treating it as an int;
        public void TurnRight()
        {
            // if x/y not valid ignore input
            if (!HasValidXY())
            {
                return;
            }
            if (direction == Direction.WEST)
            {
                direction = Direction.NORTH;
            }
            else
            {
                direction++;
            }
        }
        public void TurnLeft()
        {
            // if x/y not valid ignore input.
            if (!HasValidXY())
            {
                return;
            }
            if (direction == Direction.NORTH)
            {
                direction = Direction.WEST;
            }
            else
            {
                direction--;
            }

        }
    }
}
