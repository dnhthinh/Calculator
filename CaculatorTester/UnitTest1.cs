using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CaculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Caculation c;
        public TestContext TestContext { get; set;}
        [TestInitialize]// Thiết lập dữ liệu dùng chung cho test case
        
        public void SetUp()
        {
            c = new Caculation(10, 5);
        }
        [TestMethod]
        public void TestAddOperator()
        {
            int expected, actual;
           // Caculation c = new Caculation(10, 5);
            expected = 15;
            actual = c.Exectute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSubOperator()
        {
            int expected, actual;
            //Caculation c = new Caculation(10, 5);
            expected = 5;
            actual = c.Exectute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMulOperator()
        {
            int expected, actual;
            //Caculation c = new Caculation(10, 5);
            expected = 50;
            actual = c.Exectute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDivOperator()
        {
            int expected, actual;
            //Caculation c = new Caculation(10, 5);
            expected = 2;
            actual = c.Exectute("/");
            Assert.AreEqual(expected, actual);
        }
       
        // liên kết TestData với Project
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv","TestData#csv",DataAccessMethod.Sequential)]
        public void TestWithDataSource()
        {          
            int a,b,expected, actual;
            string operation;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b= int.Parse(TestContext.DataRow[1].ToString());
            operation = TestContext.DataRow[2].ToString();
            operation = operation.Remove(0, 1);
            expected = int.Parse(TestContext.DataRow[3].ToString());
            c = new Caculation(a, b);
            actual = c.Exectute(operation);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestDataPower.csv", "TestDataPower#csv", DataAccessMethod.Sequential)]
        public void TestPower()
        {
            int n;
            double actual;
            double expected, x;
            n = int.Parse(TestContext.DataRow[1].ToString());
            x = double.Parse(TestContext.DataRow[0].ToString());
            expected = double.Parse(TestContext.DataRow[2].ToString());
            actual = Caculation.Power(x, n);
            Assert.AreEqual(expected, actual);
        }
    }
}
