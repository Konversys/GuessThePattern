using GuessThePattern.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class ControllerTest
    {
        [TestMethod]
        public void ControllerDefine()
        {
            Controller controller = new Controller();
            Assert.IsNotNull(controller);
        }
        [TestMethod]
        public void ControllerNotStart()
        {
            Controller controller = new Controller();
            Assert.IsFalse(controller.CheckIsStart());
        }
        [TestMethod]
        public void ControllerStart()
        {
            Controller controller = new Controller();
            controller.Start();
            Assert.IsTrue(controller.CheckIsStart());
        }
        [TestMethod]
        public void ControllerNextPattern()
        {
            Controller controller = new Controller();
            controller.Start();
            controller.Next();
            Assert.IsNotNull(controller.Patterns);
        }
        [TestMethod]
        public void ControllerNextRAnswer()
        {
            Controller controller = new Controller();
            controller.Start();
            controller.Next();
            Assert.IsNotNull(controller.RightAnswer);
        }
        [TestMethod]
        public void ControllerComplete()
        {
            Controller controller = new Controller();
            controller.Start();
            for (int i = 0; i < controller.Max + 1; i++)
            {
                controller.Next();
            }
            Assert.IsTrue(controller.CheckIsStart());
        }
        [TestMethod]
        public void ControllerScope()
        {
            Controller controller = new Controller();
            controller.Start();
            controller.TakeRightAnwer();
            controller.TakeRightAnwer();
            Assert.AreEqual((int)100 * 2 / controller.Max, controller.GetScore());
        }
        [TestMethod]
        public void ControllerCount()
        {
            Controller controller = new Controller();
            controller.Start();
            controller.Next();
            controller.Next();
            Assert.AreEqual(2, controller.Count);
        }
        [TestMethod]
        public void ControllerRightPattern()
        {
            Controller controller = new Controller();
            controller.Start();
            controller.Next();
            Assert.IsInstanceOfType(controller.RightAnswer, typeof(int));
        }
        [TestMethod]
        public void ControllerDetermineTask()
        {
            Controller controller = new Controller();
            controller.Start();
            Assert.IsNotNull(controller.DetermineTask());
        }
    }
}
