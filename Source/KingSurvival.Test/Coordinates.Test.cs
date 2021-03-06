﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KingSurvival;

namespace KingSurvivalTest
{
    [TestClass]
    public class CoordinatesTest
    {
        [TestMethod]
        public void CheckOperatorEquals()
        {
            Coordinates fCoord = new Coordinates(2,3);
            Coordinates sCoord = new Coordinates(2,3);
            bool check = fCoord == sCoord;
            Assert.IsTrue(check);
        }

        [TestMethod]
        public void CheckOperatorSummary()
        {
            Coordinates fCoord = new Coordinates(2, 3);
            Coordinates sCoord = new Coordinates(2, 3);
            Coordinates sumCoord = fCoord + sCoord;
            bool Xchack = sumCoord.XCoord == 4;
            bool Ycheck = sumCoord.YCoord == 6;

            Assert.IsTrue(Xchack&&Ycheck);
        }

        [TestMethod]
        public void TestCoordConstructor()
        {
            int checkX = 2;
            int checkY = 3;
            Coordinates fCoord = new Coordinates(2, 3);
            bool testX = fCoord.XCoord == checkX;
            bool testY = fCoord.YCoord == checkY;
            Assert.IsTrue(testX && testY);

        }
    }
}
