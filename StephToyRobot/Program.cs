using System;

namespace StephToyRobot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Robot robot = null;
            var thing = new Program();
            string input = Console.ReadLine();
            //ignore all input until a place command is given
            while (input[0] != 'P')
            {
                input = Console.ReadLine();
            }
            robot = new Robot((int)char.GetNumericValue(input[6]), (int)char.GetNumericValue(input[8]), input[10]);
            while (true)
            {
                input = Console.ReadLine();
                thing.UserInput(input, ref robot);
            }
        }

        public void UserInput(string input, ref Robot robot)
        {
            switch (input)
            {
                case "MOVE":
                    robot.Move();
                    break;
                case "LEFT":
                    robot.TurnLeft();
                    break;
                case "RIGHT":
                    robot.TurnRight();
                    break;
                case "REPORT":
                    Console.WriteLine(robot.x + "," + robot.y + "," + robot.direction);
                    break;
                default:
                    if (input[0] == 'P')
                    {
                        robot = new Robot((int)char.GetNumericValue(input[6]), (int)char.GetNumericValue(input[8]), input[10]);
                    }
                    break;
            }
        }
    }
}
