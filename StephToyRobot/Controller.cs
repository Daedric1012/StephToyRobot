using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephToyRobot
{
    public class Controller
    {
        Robot robot;
        public Controller(Robot robot) { 
            this.robot = robot;
        }

        public void UserInput(string input)
        {
            //all input less than 4 characters will be invalid input so exit;
            if (input.Length < 4) { return; }

            // We don't need case sensitive input.
            input = input.ToUpper();

            int spaceIndex = input.IndexOf(' ');
            string command;
            string action;
            if (spaceIndex > 0)
            {
                command = input.Substring(0, spaceIndex);
            }
            else
            {
                command = input;
            }

            switch (command)
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
                    string report = robot.Report();
                    if(report != null)
                    {
                        Console.WriteLine(report);
                    }
                    break;
                case "PLACE":
                    // break down 2nd part of the input string to get x, y and direction;
                    action = input.Substring(spaceIndex + 1, input.Length - (spaceIndex+1));
                    int firstSeparator = action.IndexOf(",");
                    int secondSeparator = action.IndexOf(",", firstSeparator + 1);
                    int x = -1;
                    int y = -1;
                    char direction = 'b';
                    if(firstSeparator == -1 || secondSeparator == -1)
                    {
                        return; // invalid input, exit.
                    }
                    try
                    {
                        x = int.Parse(action.Substring(0, firstSeparator));
                        y = int.Parse(action.Substring(firstSeparator + 1, secondSeparator - (firstSeparator+1)));
                        direction = action[secondSeparator+1];
                    }
                    catch (Exception e) {
                        return; // invalid input, exit.
                    }
                    robot.Place(x,y,direction);
                    break;
                default:
                    break;
            }
        }
    }
}
