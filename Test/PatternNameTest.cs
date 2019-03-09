using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class PatternsNameTest
    {
        [TestMethod]
        public void TestAbstractFactory()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.AbstractFactory);
            Assert.AreEqual(Name.AbstractFactory, pattern.Name);
        }
        [TestMethod]
        public void TestAdapter()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Adapter);
            Assert.AreEqual(Name.Adapter, pattern.Name);
        }
        [TestMethod]
        public void TestBuilder()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Builder);
            Assert.AreEqual(Name.Builder, pattern.Name);
        }
        [TestMethod]
        public void TestCommand()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Command);
            Assert.AreEqual(Name.Command, pattern.Name);
        }
        [TestMethod]
        public void TestDecorator()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Decorator);
            Assert.AreEqual(Name.Decorator, pattern.Name);
        }
        [TestMethod]
        public void TestFactoryMethod()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.FactoryMethod);
            Assert.AreEqual(Name.FactoryMethod, pattern.Name);
        }
        [TestMethod]
        public void TestIterator()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Iterator);
            Assert.AreEqual(Name.Iterator, pattern.Name);
        }
        [TestMethod]
        public void TestPrototype()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Prototype);
            Assert.AreEqual(Name.Prototype, pattern.Name);
        }
        [TestMethod]
        public void TestStrategy()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Strategy);
            Assert.AreEqual(Name.Strategy, pattern.Name);
        }
    }
}
