using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PigRace;
using PigRace.Business;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test that the random number is between 1 and 5
        /// </summary>
        [TestMethod]
        public void TestRandomNumber()
        {
            Random rnd = new Random();
            int result = rnd.Next(1, 5);

            Assert.IsTrue(result >= 1 && result <= 5);
        }
        /// <summary>
        /// Test that the number is not greater than 5
        /// </summary>
        [TestMethod]
        public void TestLargeNumber()
        {
            Random rnd = new Random();
            int result = rnd.Next(1, 5);

            Assert.IsFalse(result > 5);
        }
        /// <summary>
        /// Test that the values from instantiation are set using the factory method
        /// </summary>
        [TestMethod]
        public void TestValuesFromInstantiation()
        {
            Punter[] myPunter = new Punter[3];
            int Id = 1;
            string name = "Farmer Brown";
            myPunter[1] = Factory.GetAPunter(Id);

            Assert.AreEqual(name, myPunter[1].PunterName);
        }
    }
}
