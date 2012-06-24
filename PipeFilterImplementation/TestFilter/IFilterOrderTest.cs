using Filters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Order;
using System.Collections.Generic;

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


        internal virtual IFilter_Accessor CreateIFilter_Accessor()
        {
            // TODO: Instantiate an appropriate concrete class.
            IFilter_Accessor target = null;
            return target;
        }

        /// <summary>
        ///A test for BufferToString
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Filters.dll")]
        public void BufferToStringTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            IFilter_Accessor target = new IFilter_Accessor(param0); // TODO: Initialize to an appropriate value
            Queue<AbstractOrder> buffer = new Queue<AbstractOrder>(); // TODO: Initialize to an appropriate value
            
            List<string> expected = null; // TODO: Initialize to an appropriate value
            List<string> actual;
            actual = target.BufferToString(buffer);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        internal virtual IFilter CreateIFilter()
        {
            // TODO: Instantiate an appropriate concrete class.
            IFilter target = null;
            return target;
        }

        /// <summary>
        ///A test for InputBufferToString
        ///</summary>
        [TestMethod()]
        public void InputBufferToStringTest()
        {
            IFilter target = CreateIFilter(); // TODO: Initialize to an appropriate value
            List<string> expected = null; // TODO: Initialize to an appropriate value
            List<string> actual;
            actual = target.InputBufferToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OutputBufferToString
        ///</summary>
        [TestMethod()]
        public void OutputBufferToStringTest()
        {
            IFilter target = CreateIFilter(); // TODO: Initialize to an appropriate value
            List<string> expected = null; // TODO: Initialize to an appropriate value
            List<string> actual;
            actual = target.OutputBufferToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Process
        ///De test staat ook beschrijven in het methode testplan
        ///dit is test 3.1
        ///</summary>
        [TestMethod()]
        public void ProcessTest()
        {
            IFilter target = CreateIFilter(); // TODO: Initialize to an appropriate value
            int expected = target.InputBufferToString().Count - 1;
            this.orderFac = new DefaultOrderFactory();
            int rand = 0;
            AbstractOrder order = (rand == 0) ?
                this.orderFac.CreateOrder("desktop") : this.orderFac.CreateOrder("laptop");
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
            AbstractOrder expected = (rand == 0) ?
                this.orderFac.CreateOrder("desktop") : this.orderFac.CreateOrder("laptop");
            IFilter target = CreateIFilter(); // TODO: Initialize to an appropriate value
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
            IFilter target = CreateIFilter(); // TODO: Initialize to an appropriate value
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

            IFilter target = CreateIFilter(); // TODO: Initialize to an appropriate value
            int expected = target.InputBufferToString().Count + 1;
            this.orderFac = new DefaultOrderFactory();
            int rand = 0;
            AbstractOrder order = (rand == 0) ?
                this.orderFac.CreateOrder("desktop") : this.orderFac.CreateOrder("laptop");
            target.Push(order);
            int actual = target.InputBufferToString().Count;
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
            IFilter target = CreateIFilter(); // TODO: Initialize to an appropriate value
            int expected = target.InputBufferToString().Count;
            AbstractOrder order = null; // TODO: Initialize to an appropriate value
            target.Push(order);
            int actual = target.InputBufferToString().Count;
            Assert.AreEqual(expected, actual);
        }
    }
}
