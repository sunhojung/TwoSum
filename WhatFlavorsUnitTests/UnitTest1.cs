using System;
using IceCream;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhatFlavorsUnitTests
{
    [TestClass]
    public class whatFlavorsUnitTests
    {
        [TestMethod]
        public void minimumFlavors()
        {
            int[] costs = new int[2] { 3, 5 };
            int[] trueValues = new int[2] { 1, 2 };
            int[] returnValues = WhatFlavors.GetFlavors(costs, 8);
            Assert.AreEqual(returnValues[0], trueValues[0]);
            Assert.AreEqual(returnValues[1], trueValues[1]);
        }

        [TestMethod]
        public void lostOfDuplicateCosts()
        {
            int[] costs = new int[20] { 1,1,2,2,3,3,4,4,5,5,6,6,7,7,8,8,9,9,10,10 };
            int[] trueValues = new int[2] { 1, 3 };
            int[] returnValues = WhatFlavors.GetFlavors(costs, 3);
            Assert.AreEqual(returnValues[0], trueValues[0]);
            Assert.AreEqual(returnValues[1], trueValues[1]);
        }

        [TestMethod]
        public void lostOfDuplicateCosts2()
        {
            int[] costs = new int[20] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10 };
            int[] trueValues = new int[2] { 1, 5 };
            int[] returnValues = WhatFlavors.GetFlavors(costs, 4);
            Assert.AreEqual(returnValues[0], trueValues[0]);
            Assert.AreEqual(returnValues[1], trueValues[1]);
        }

        [TestMethod]
        public void lostOfDuplicateCosts3()
        {
            int[] costs = new int[20] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10 };
            int[] trueValues = new int[2] { 1, 2 };
            int[] returnValues = WhatFlavors.GetFlavors(costs, 2);
            Assert.AreEqual(returnValues[0], trueValues[0]);
            Assert.AreEqual(returnValues[1], trueValues[1]);
        }

        [TestMethod]
        public void lostOfDuplicateCosts4()
        {
            int[] costs = new int[21] { 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7};
            int[] trueValues = new int[2] {19, 20 };
            int[] returnValues = WhatFlavors.GetFlavors(costs, 14);
            Assert.AreEqual(returnValues[0], trueValues[0]);
            Assert.AreEqual(returnValues[1], trueValues[1]);
        }


        [TestMethod]
        public void randomisedArray()
        {
            int[] costs = new int[10] { 113, 2255, 21, 54, 500, 67, 89, 901, 233, 5001 };
            int[] trueValues = new int[2] { 5, 10 };
            int[] returnValues = WhatFlavors.GetFlavors(costs, 5501);
            Assert.AreEqual(returnValues[0], trueValues[0]);
            Assert.AreEqual(returnValues[1], trueValues[1]);
        }

    }
}
