using Filters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Order;
using Pipes;
using PFFactory;
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
        private IPipeFilterFactory pffactory;

        private TestContext testContextInstance;

        public IPipeOrderTest()
        {
            pffactory = new PipeFilterFactory();
        }

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
            IPipe target = new Pipe();
            return target;
        }


        /// <summary>
        ///A test for Transport
        ///De test staat ook beschrijven in het methode testplan
        ///dit is test 5.1
        ///</summary>
        [TestMethod()]
        public void TransportTest()
        {
            IPipe target = CreateIPipe(); // TODO: Initialize to an appropriate value
            IFilter target2 = pffactory.CreateFilter("SWTEST");
            int expected = target2.InputBufferToString().Count + 1;
            AbstractOrder order = null; // TODO: Initialize to an appropriate value
            target.Transport();
            int actual = target2.InputBufferToString().Count;
            Assert.AreEqual(expected, actual);
        }
    }
}
