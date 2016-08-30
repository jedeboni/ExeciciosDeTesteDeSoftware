using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCPF1()
        {
            CPF cpf = new CPF();
            Assert.IsTrue(cpf.validarCPF("11111111111"));
        }

        [TestMethod]
        public void TestCPFInvalido()
        {
            CPF cpf = new CPF();
            Assert.IsFalse(cpf.validarCPF("11111111112"));
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestCPF1()
        {
            CPF cpf = new CPF();
            Assert.IsTrue(cpf.validarCPF("11111111111"));
        }

        [TestMethod]
        public void TestCPFInvalido()
        {
            CPF cpf = new CPF();
            Assert.IsFalse(cpf.validarCPF("11111111112"));
        }
    }
}
