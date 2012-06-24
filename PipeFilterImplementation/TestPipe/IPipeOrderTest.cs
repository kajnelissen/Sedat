using Filters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Order;
using Pipes;
using System.Collections.Generic;

namespace TestPipe
{
    
    
    /// <summary>
    ///This is a test class for IPipeOrderTest and is intended
    ///to contain all IPipeOrderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IPipeOrderTest
    {


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

        internal virtual IFilter CreateIFilter()
        {
            // TODO: Instantiate an appropriate concrete class.
            IFilter target = null;
            return target;
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        internal virtual IPipe CreateIPipe()
        {
            // TODO: Instantiate an appropriate concrete class.
            IPipe target = null;
            return target;
        }

        /// <summary>
        ///A test for Connect
        ///De test staat ook beschrijven in het methode testplan
        ///dit is test 4.1
        ///</summary>
        //[TestMethod()]
        //public void ConnectTest()
        //{
        //    IPipe target = CreateIPipe(); // TODO: Initialize to an appropriate value
        //    IFilter from = null; // TODO: Initialize to an appropriate value
        //    IFilter fromExpected = null; // TODO: Initialize to an appropriate value
        //    IFilter to = null; // TODO: Initialize to an appropriate value
        //    IFilter toExpected = null; // TODO: Initialize to an appropriate value
        //    target.Connect(ref from, ref to);
        //    Assert.AreEqual(fromExpected, from);
        //    Assert.AreEqual(toExpected, to);
        //    Assert.Inconclusive("A method that does not return a value cannot be verified.");
        //}

        ///// <summary>
        /////A test for SetEndPoint
        /////</summary>
        //[TestMethod()]
        //public void SetEndPointTest()
        //{
        //    IPipe target = CreateIPipe(); // TODO: Initialize to an appropriate value
        //    IFilter to = null; // TODO: Initialize to an appropriate value
        //    IFilter toExpected = null; // TODO: Initialize to an appropriate value
        //    target.SetEndPoint(ref to);
        //    Assert.AreEqual(toExpected, to);
        //    Assert.Inconclusive("A method that does not return a value cannot be verified.");
        //}

        ///// <summary>
        /////A test for SetStartPoint
        /////</summary>
        //[TestMethod()]
        //public void SetStartPointTest()
        //{
        //    IPipe target = CreateIPipe(); // TODO: Initialize to an appropriate value
        //    IFilter from = null; // TODO: Initialize to an appropriate value
        //    IFilter fromExpected = null; // TODO: Initialize to an appropriate value
        //    target.SetStartPoint(ref from);
        //    Assert.AreEqual(fromExpected, from);
        //    Assert.Inconclusive("A method that does not return a value cannot be verified.");
        //}

        /// <summary>
        ///A test for Transport
        ///De test staat ook beschrijven in het methode testplan
        ///dit is test 5.1
        ///</summary>
        [TestMethod()]
        public void TransportTest()
        {
            IPipe target = CreateIPipe(); // TODO: Initialize to an appropriate value
            IFilter target2 = CreateIFilter();
            int expected = target2.InputBufferToString().Count + 1;
            AbstractOrder order = null; // TODO: Initialize to an appropriate value
            target.Transport();
            int actual = target2.InputBufferToString().Count;
            Assert.AreEqual(expected, actual);
        }
    }
}
