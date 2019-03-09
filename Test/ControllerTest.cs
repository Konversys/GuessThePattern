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
        public void ControllerNotStart()
        {
            Controller controller = new Controller();
            Assert.IsFalse(controller.CheckIsStart());
        }
        public void ControllerStart()
        {
            Controller controller = new Controller();
            controller.Start();
            Assert.IsTrue(controller.CheckIsStart());
        }
        public void ControllerNextPattern()
        {
            Controller controller = new Controller();
            controller.Start();
            controller.Next();
            Assert.IsNotNull(controller.Patterns);
        }
        public void ControllerNextRAnswer()
        {
            Controller controller = new Controller();
            controller.Start();
            controller.Next();
            Assert.IsNotNull(controller.RightAnswer);
        }
        public void ControllerComplete()
        {
            Controller controller = new Controller();
            controller.Start();
            for (int i = 0; i < controller.Max + 1; i++)
            {
                controller.Next();
            }
            Assert.IsFalse(controller.CheckIsStart());
        }
        public void ControllerScope()
        {
            Controller controller = new Controller();
            controller.Start();
            controller.TakeRightAnwer();
            controller.TakeRightAnwer();
            Assert.AreEqual(controller.GetScore(), (int)100 * 2 / controller.Max);
        }
        public void ControllerCount()
        {
            Controller controller = new Controller();
            controller.Start();
            controller.Next();
            controller.Next();
            Assert.AreEqual(controller.Count, 3);
        }
        public void ControllerRightPattern()
        {
            Controller controller = new Controller();
            controller.Start();
            Assert.IsNotNull(controller.GetRightPattern());
        }
        public void ControllerRightPattern()
        {
            Controller controller = new Controller();
            controller.Start();
            Assert.IsNotNull(controller.DetermineTask());
        }
    }
}
