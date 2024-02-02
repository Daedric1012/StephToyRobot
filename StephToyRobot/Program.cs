using System;
using System.Runtime.CompilerServices;

namespace StephToyRobot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Robot robot = new Robot();
            Controller controller = new Controller(robot);
            string input;
            // send user input to the controller.
            while (true)
            {
                input = Console.ReadLine();
                controller.UserInput(input);
            }
        }
    }
}
