using Filters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Order;
using System.Collections.Generic;
using PFFactory;

namespace TestFilter
{
    
    
    /// <summary>
    ///This is a test class for IFilterOrderTest and is intended
    ///to contain all IFilterOrderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IFilterOrderTest
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

        public IFilterOrderTest()
        {
            pffactory = new PipeFilterFactory();
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

        private IPipeFilterFactory pffactory;


        

        /// <summary>
        ///A test for Process
        ///De test staat ook beschrijven in het methode testplan
        ///dit is test 3.1
        ///</summary>
        [TestMethod()]
        public void ProcessTest()
        {
            IFilter target = pffactory.CreateFilter("HWTEST"); // TODO: Initialize to an appropriate value
            
            this.orderFac = new DefaultOrderFactory();
            int rand = 0;
            AbstractOrder order = (rand == 0) ?
                this.orderFac.CreateOrder("desktop") : this.orderFac.CreateOrder("laptop");
            int expected = target.InputBufferToString().Count + 1;
            target.Push(order);
            int actual = target.InputBufferToString().Count;
            Assert.AreEqual(expected, actual);
        }

        private IOrderFactory orderFac;

        /// <summary>
        ///A test for Pull
        ///De test staat ook beschrijven in het methode testplan
        ///dit is test 2.1
        ///</summary>
        [TestMethod()]
        public void PullTest()
        {
            this.orderFac = new DefaultOrderFactory();
            int rand = 0;
            AbstractOrder expected = null;
            AbstractOrder order = (rand == 0) ?
                this.orderFac.CreateOrder("desktop") : this.orderFac.CreateOrder("laptop");
            IFilter target = pffactory.CreateFilter("SWTEST"); // TODO: Initialize to an appropriate value
            AbstractOrder actual;
            actual = target.Pull();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Pull
        ///De test staat ook beschrijven in het methode testplan
        ///dit is test 2.2
        ///</summary>
        [TestMethod()]
        public void PullTest2()
        {
            AbstractOrder expected = null;
            IFilter target = pffactory.CreateFilter("HWASSEMBLE"); // TODO: Initialize to an appropriate value
            AbstractOrder actual;
            actual = target.Pull();
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for Push
        ///De test staat ook beschrijven in het methode testplan
        ///dit is test 1.1
        ///</summary>
        [TestMethod()]
        public void PushTest1()
        {
            IFilter target = pffactory.CreateFilter("HWASSEMBLE"); // TODO: Initialize to an appropriate value
            int expected = 0;
            foreach (KeyValuePair<int, AbstractOrder> a in target.Input)
            {
                expected++;
            }
            expected = +1;
            this.orderFac = new DefaultOrderFactory();
            AbstractOrder order = this.orderFac.CreateOrder("desktop");
            target.Push(order);
            int actual = 0;
            foreach (KeyValuePair<int, AbstractOrder> a in target.Input)
            {
                actual++;
            }
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Push
        ///De test staat ook beschrijven in het methode testplan
        ///dit is test 1.2
        ///</summary>
        [TestMethod()]
        public void PushTest2()
        {
            IFilter target = pffactory.CreateFilter("HWTEST"); // TODO: Initialize to an appropriate value
            int expected = 0;
            foreach (KeyValuePair<int, AbstractOrder> a in target.Input)
            {
                expected++;
            }

            AbstractOrder order = null; // TODO: Initialize to an appropriate value
            target.Push(order);
            int actual = 0;
            foreach (KeyValuePair<int, AbstractOrder> a in target.Input)
            {
                actual++;
            }
            Assert.AreEqual(expected, actual);
        }

    }
}
