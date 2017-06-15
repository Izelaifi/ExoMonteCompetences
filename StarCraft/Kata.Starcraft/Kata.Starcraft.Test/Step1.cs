using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata.Starcraft;
using System.IO;

namespace Kata.Starcraft.Test
{
    [TestClass]
    public class Step1
    {
        [TestMethod]
        public void TestMarineHas50HpWhenCreated()
        {
            Marine newUnit = new Marine();
            Assert.Equals(50, newUnit.Hp);
        }
        [TestMethod]
        public void TestMarineHas7AttackWhenCreated()
        {
            Marine newUnit = new Marine();
            Assert.Equals(7, newUnit.Attack);
        }
        [TestMethod]
        public void TestMarineHas3SpeedWhenCreated()
        {
            Marine newUnit = new Marine();
            Assert.Equals(3, newUnit.Speed);
        }
        [TestMethod]
        public void TestMarineGet5Damages()
        {
            Marine newUnit = new Marine();
            newUnit.GetDamage(5);
            Assert.Equals(45, newUnit.Hp);
        }
        [TestMethod]
        public void TestMarineDies()
        {
            Marine newUnit = new Marine();
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                newUnit.GetDamage(50);
                Assert.AreEqual("ARRRRRRRRRRRRRGH", sw.ToString());
            }
        }
    }
}
