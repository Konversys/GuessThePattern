using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class PatternsUMLTest
    {
        [TestMethod]
        public void TestAbstractFactory()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.AbstractFactory);
            Assert.AreEqual(pattern.UML, Images.AbstractFactory);
        }
        [TestMethod]
        public void TestAdapter()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Adapter);
            Assert.AreEqual(pattern.UML, Images.Adapter);
        }
        [TestMethod]
        public void TestBuilder()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Builder);
            Assert.AreEqual(pattern.UML, Images.Builder);
        }
        [TestMethod]
        public void TestCommand()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Command);
            Assert.AreEqual(pattern.UML, Images.Command);
        }
        [TestMethod]
        public void TestDecorator()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Decorator);
            Assert.AreEqual(pattern.UML, Images.Decorator);
        }
        [TestMethod]
        public void TestFactoryMethod()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.FactoryMethod);
            Assert.AreEqual(pattern.UML, Images.FactoryMethod);
        }
        [TestMethod]
        public void TestIterator()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Iterator);
            Assert.AreEqual(pattern.UML, Images.Iterator);
        }
        [TestMethod]
        public void TestPrototype()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Prototype);
            Assert.AreEqual(pattern.UML, Images.Prototype);
        }
        [TestMethod]
        public void TestStrategy()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Strategy);
            Assert.AreEqual(pattern.UML, Images.Strategy);
        }
    }
}
