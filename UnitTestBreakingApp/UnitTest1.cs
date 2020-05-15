using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreakingAppCA2;

namespace UnitTestBreakingApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Breaking_Distance_v1()
        {
            // ARRANGE
            Vehicles v1 = new Vehicles();
           
             double breakingDistance = 50;
            double expectedBreakingDistance = breakingDistance;
            //ACT
           
            breakingDistance= v1.Get_Breaking_DistanceInMPH(25);
            
            // ASSERT

            Assert.AreEqual(expectedBreakingDistance, breakingDistance);
        }
        [TestMethod]
        public void Breaking_Distance_v2()
        {
            // ARRANGE
            Vehicles v1 = new Vehicles();
           
            double breakingDistance = 0.0;
            double expectedBreakingDistance = 206.5;
            //ACT
            
           
            breakingDistance = v1.Get_Breaking_DistanceInMPH(59);
           
            // ASSERT

            Assert.AreEqual(expectedBreakingDistance, breakingDistance);
        }
        [TestMethod]
        public void TestMethod3()
        {
            // ARRANGE
            Vehicles v1 = new Vehicles();

            v1.VehicleType = "Car";

            double breakingDistance = 0.0;
            double expectedBreakingDistance = 606;
            //ACT
            

            breakingDistance = v1.Get_Breaking_DistanceInMPH(101);

            // ASSERT

            Assert.AreEqual(expectedBreakingDistance, breakingDistance);
        }
    }
}
