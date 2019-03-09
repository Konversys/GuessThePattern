using System;
using System.IO;
using GuessThePattern.Model.Map;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class CodeTest
    {
        [TestMethod]
        public void TestAdaper()
        {
            Assert.IsTrue(Code.Adapter.Contains("ITransport camelTransport = new CamelToTransportAdapter(camel);"));
        }

        [TestMethod]
        public void TestAbstractFactory()
        {
            Assert.IsTrue(Code.AbstractFactory.Contains("Hero elf = new Hero(new ElfFactory());"));
        }

        [TestMethod]
        public void TestStrategy()
        {
            Assert.IsTrue(Code.Strategy.Contains("Car auto = new Car(4, \"Volvo\", new PetrolMove());"));
        }
    }
}
