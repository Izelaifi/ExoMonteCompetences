using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Kata.Starcraft.Test
{
    [TestClass]
    public class Step2
    {
        [TestMethod]
        public void TestHellionHas45HpWhenCreated()
        {
            Hellion newUnit = new Hellion();
            Assert.Equals(45, newUnit.Hp);
        }
        [TestMethod]
        public void TestHellionHas14AttackWhenCreated()
        {
            Hellion newUnit = new Hellion();
            Assert.Equals(14, newUnit.Attack);
        }
        [TestMethod]
        public void TestHellionHas18SpeedWhenCreated()
        {
            Hellion newUnit = new Hellion();
            Assert.Equals(18, newUnit.Speed);
        }
        [TestMethod]
        public void TestHellionGet12Damages()
        {
            Hellion newUnit = new Hellion();
            newUnit.GetDamage(12);
            Assert.Equals(33, newUnit.Hp);
        }
        [TestMethod]
        public void TestHellionDies()
        {
            Hellion newUnit = new Hellion();
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                newUnit.GetDamage(45);
                Assert.AreEqual("Bouuuuuuuuuuum", sw.ToString());
            }
        }
    }
}
