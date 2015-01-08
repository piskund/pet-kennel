using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mechs.Common.Interfaces;
using Mechs.BL.BusinessObjects;

namespace TestMechBL
{
    /// <summary>
    /// Summary description for TimeLineTest
    /// </summary>
    [TestClass]
    public class TimeLineTest
    {
        public TimeLineTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestTimeLine()
        {
            TimeLine timeLine = TimeLine.Instance as TimeLine;
            Assert.AreEqual(0, timeLine.Day);

            timeLine.IncrementDay(8);
            ulong turnNum = 8;
            Assert.AreEqual(turnNum, timeLine.TurnNumber);
            Assert.AreEqual(0, timeLine.DayOfWeek);
            Assert.AreEqual(8, timeLine.DayOfYear);
            Assert.AreEqual(1, timeLine.Week);
            Assert.AreEqual(0, timeLine.Month);
            Assert.AreEqual(0, timeLine.Year);

            timeLine.IncrementDay(192);
            turnNum = 200;
            Assert.AreEqual(turnNum, timeLine.TurnNumber);
            Assert.AreEqual(0, timeLine.DayOfWeek);
            Assert.AreEqual(200, timeLine.DayOfYear);
            Assert.AreEqual(26, timeLine.Week);
            Assert.AreEqual(5, timeLine.Month);
            Assert.AreEqual(0, timeLine.Year);
        }
    }
}
