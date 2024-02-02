using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using StephToyRobot;

namespace StephToyRobotTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            const string Expected = "0,1,NORTH";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Robot robot = new Robot();
                Controller controller = new Controller(robot);
                controller.UserInput("PLACE 0,0,NORTH");
                controller.UserInput("MOVE");
                controller.UserInput("REPORT");

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            const string Expected = "3,3,NORTH";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Robot robot = new Robot();
                Controller controller = new Controller(robot);
                controller.UserInput("PLACE 1,2,EAST");
                controller.UserInput("MOVE");
                controller.UserInput("MOVE");
                controller.UserInput("LEFT");
                controller.UserInput("MOVE");
                controller.UserInput("REPORT");

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
