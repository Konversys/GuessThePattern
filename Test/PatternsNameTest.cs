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
            Assert.AreEqual(pattern.Name, Name.AbstractFactory);
        }
        [TestMethod]
        public void TestAdapter()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Adapter);
            Assert.AreEqual(pattern.Name, Name.Adapter);
        }
        [TestMethod]
        public void TestBuilder()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Builder);
            Assert.AreEqual(pattern.Name, Name.Builder);
        }
        [TestMethod]
        public void TestCommand()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Command);
            Assert.AreEqual(pattern.Name, Name.Command);
        }
        [TestMethod]
        public void TestDecorator()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Decorator);
            Assert.AreEqual(pattern.Name, Name.Decorator);
        }
        [TestMethod]
        public void TestFactoryMethod()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.FactoryMethod);
            Assert.AreEqual(pattern.Name, Name.FactoryMethod);
        }
        [TestMethod]
        public void TestIterator()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Iterator);
            Assert.AreEqual(pattern.Name, Name.Iterator);
        }
        [TestMethod]
        public void TestPrototype()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Prototype);
            Assert.AreEqual(pattern.Name, Name.Prototype);
        }
        [TestMethod]
        public void TestStrategy()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Strategy);
            Assert.AreEqual(pattern.Name, Name.Strategy);
        }
    }
}
