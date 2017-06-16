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
            Assert.AreEqual(50, newUnit.Hp);
        }
        [TestMethod]
        public void TestMarineHas7AttackWhenCreated()
        {
            Marine newUnit = new Marine();
            Assert.AreEqual(7, newUnit.Attack);
        }
        [TestMethod]
        public void TestMarineHas3SpeedWhenCreated()
        {
            Marine newUnit = new Marine();
            Assert.AreEqual(3, newUnit.Speed);
        }
        [TestMethod]
        public void TestMarineGet5Damages()
        {
            Marine newUnit = new Marine();
            newUnit.GetDamage(5);
            Assert.AreEqual(45, newUnit.Hp);
        }
        [TestMethod]
        public void TestMarineDies()
        {
            Marine newUnit = new Marine();
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);
                newUnit.GetDamage(50);
                Assert.AreEqual("ARRRRRRRRRRRRRG", sw.ToString());
            }
        }
    }
}
