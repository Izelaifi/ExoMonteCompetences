using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata.Starcraft.Test
{
    [TestClass]
    public class Step3
    {
        [TestMethod]
        public void TestMarineWithoutArmorTakesNormalDamage()
        {
            Marine newMarine = new Marine();
            newMarine.GetDamage(10);
            Assert.Equals(40, newMarine.Hp);
        }
        [TestMethod]
        public void TestMarineWithArmorTakesLessDamage()
        {
            Marine newMarine = new Marine();
            //Rajouter la modification d'armure
            throw new NotImplementedException();
            newMarine.GetDamage(10);
            Assert.Equals(45, newMarine.Hp);
        }
    }
}
