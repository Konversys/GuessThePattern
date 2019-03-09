using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class PatternsTitleTest
    {
        [TestMethod]
        public void TestAbstractFactory()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.AbstractFactory);
            Assert.AreEqual("Абстрактная фабрика", pattern.Title);
        }
        [TestMethod]
        public void TestAdapter()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Adapter);
            Assert.AreEqual("Адаптер", pattern.Title);
        }
        [TestMethod]
        public void TestBuilder()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Builder);
            Assert.AreEqual("Строитель", pattern.Title);
        }
        [TestMethod]
        public void TestCommand()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Command);
            Assert.AreEqual("Команда", pattern.Title);
        }
        [TestMethod]
        public void TestDecorator()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Decorator);
            Assert.AreEqual("Декоратор", pattern.Title);
        }
        [TestMethod]
        public void TestFactoryMethod()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.FactoryMethod);
            Assert.AreEqual("Фабричный метод", pattern.Title);
        }
        [TestMethod]
        public void TestIterator()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Iterator);
            Assert.AreEqual("Итератор", pattern.Title);
        }
        [TestMethod]
        public void TestPrototype()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Prototype);
            Assert.AreEqual("Прототип", pattern.Title);
        }
        [TestMethod]
        public void TestStrategy()
        {
            Patterns patterns = new Patterns();
            Pattern pattern = patterns.GetPattern(Name.Strategy);
            Assert.AreEqual("Стратегия", pattern.Title);
        }
    }
}
