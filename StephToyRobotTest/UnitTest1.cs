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
            const string Expected = "0,1,North";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program main = new Program();
                Robot robot = new Robot(5, 5, 'N');
                main.UserInput("PLACE 0,0,NORTH", ref robot);
                main.UserInput("MOVE", ref robot);
                main.UserInput("REPORT", ref robot);

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            const string Expected = "0,0,West";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program main = new Program();
                Robot robot = new Robot(5, 5, 'N');
                main.UserInput("PLACE 0,0,NORTH", ref robot);
                main.UserInput("LEFT", ref robot);
                main.UserInput("REPORT", ref robot);

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            const string Expected = "3,3,North";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program main = new Program();
                Robot robot = new Robot(5, 5, 'N');
                main.UserInput("PLACE 1,2,EAST", ref robot);
                main.UserInput("MOVE", ref robot);
                main.UserInput("MOVE", ref robot);
                main.UserInput("LEFT", ref robot);
                main.UserInput("MOVE", ref robot);
                main.UserInput("REPORT", ref robot);

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            const string Expected = "0,0,West";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program main = new Program();
                Robot robot = new Robot(5, 5, 'N');
                main.UserInput("PLACE 0,0,NORTH", ref robot);
                main.UserInput("LEFT", ref robot);
                main.UserInput("MOVE", ref robot);
                main.UserInput("MOVE", ref robot);
                main.UserInput("MOVE", ref robot);
                main.UserInput("REPORT", ref robot);

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
