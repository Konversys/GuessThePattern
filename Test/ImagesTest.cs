using System;
using GuessThePattern.Model.Map;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class ImagesTest
    {
        [TestMethod]
        public void TestAbstractFactory()
        {
            Assert.AreEqual(DefaultPath("AbstractFactory"), Images.AbstractFactory.UriSource.AbsolutePath);
        }
        [TestMethod]
        public void TestAdapter()
        {
            Assert.AreEqual(DefaultPath("Adapter"), Images.Adapter.UriSource.AbsolutePath);
        }
        [TestMethod]
        public void TestBuilder()
        {
            Assert.AreEqual(DefaultPath("Builder"), Images.Builder.UriSource.AbsolutePath);
        }
        [TestMethod]
        public void TestCommand()
        {
            Assert.AreEqual(DefaultPath("Command"), Images.Command.UriSource.AbsolutePath);
        }
        [TestMethod]
        public void TestDecorator()
        {
            Assert.AreEqual(DefaultPath("Decorator"), Images.Decorator.UriSource.AbsolutePath);
        }
        [TestMethod]
        public void TestFactoryMethod()
        {
            Assert.AreEqual(DefaultPath("FactoryMethod"), Images.FactoryMethod.UriSource.AbsolutePath);
        }
        [TestMethod]
        public void TestIterator()
        {
            Assert.AreEqual(DefaultPath("Iterator"), Images.Iterator.UriSource.AbsolutePath);
        }
        [TestMethod]
        public void TestPrototype()
        {
            Assert.AreEqual(DefaultPath("Prototype"), Images.Prototype.UriSource.AbsolutePath);
        }
        [TestMethod]
        public void TestStrategy()
        {
            Assert.AreEqual(DefaultPath("Strategy"), Images.Strategy.UriSource.AbsolutePath);
        }

        string DefaultPath(string name)
        {
            return $"C:/Users/Konver/source/repos/GuessThePattern/GuessThePattern/Model/Map/Images/{name}.png";
        }
    }
}
