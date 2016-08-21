using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLab1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEquilatero()
        {
            SUT sut = new TestLab1.SUT();
            Assert.IsTrue(sut.Triangulos(1.0, 1.0, 1.0).Equals("equilátero"));
        }

        [TestMethod]
        public void TestIsoceles()
        {
            SUT sut = new TestLab1.SUT();
            Assert.IsTrue(sut.Triangulos(2.0, 1.0, 2.0).Equals("isóceles"));
        }

        [TestMethod]
        public void TestEscaleno()
        {
            SUT sut = new TestLab1.SUT();
            Assert.IsTrue(sut.Triangulos(2.0, 3.0, 4.0).Equals("escaleno"));
        }

        [TestMethod]
        public void TestNotTriangulo()
        {
            SUT sut = new TestLab1.SUT();
            Assert.IsTrue(sut.Triangulos2(1.0, 2.0, 3.0).Equals("ERRO"));
        }

    }
}
