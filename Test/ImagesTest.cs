using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class ImagesTest
    {
        [TestMethod]
        public void TestAbstractFactory()
        {
            Assert.AreEqual(Images.AbstractFactory.BaseUri, DefaultPath("AbstractFactory"));
        }
        [TestMethod]
        public void TestAdapter()
        {
            Assert.AreEqual(Images.AbstractFactory.BaseUri, DefaultPath("Adapter"));
        }
        [TestMethod]
        public void TestBuilder()
        {
            Assert.AreEqual(Images.AbstractFactory.BaseUri, DefaultPath("Builder"));
        }
        [TestMethod]
        public void TestCommand()
        {
            Assert.AreEqual(Images.AbstractFactory.BaseUri, DefaultPath("Command"));
        }
        [TestMethod]
        public void TestDecorator()
        {
            Assert.AreEqual(Images.AbstractFactory.BaseUri, DefaultPath("Decorator"));
        }
        [TestMethod]
        public void TestFactoryMethod()
        {
            Assert.AreEqual(Images.AbstractFactory.BaseUri, DefaultPath("FactoryMethod"));
        }
        [TestMethod]
        public void TestIterator()
        {
            Assert.AreEqual(Images.AbstractFactory.BaseUri, DefaultPath("Iterator"));
        }
        [TestMethod]
        public void TestPrototype()
        {
            Assert.AreEqual(Images.AbstractFactory.BaseUri, DefaultPath("Prototype"));
        }
        [TestMethod]
        public void TestStrategy()
        {
            Assert.AreEqual(Images.AbstractFactory.BaseUri, DefaultPath("Strategy"));
        }

        string DefaultPath(string name)
        {
            return $"D:/ASTU/8s/ВиТПО/L3/GuessThePattern/GuessThePattern/Model/Map/{name}.png";
        }
    }
}
