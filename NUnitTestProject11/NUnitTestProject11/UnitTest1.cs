using NUnit.Framework;
using System;

namespace NUnitTestProject11
{
    [TestFixture]
    [Category("category")]
    public class Tests
    {
        MyCals c;
        [OneTimeSetUp]
        public void BeforeAllMethods()
        {
            c = new MyCals();
        }

        [OneTimeTearDown]
        public void AfterAllMethods()
        {
            Assert.Pass();
        }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Begining of the test");

        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("End of the test");
        }

        [Test]
        [Category("category(1)")]
        public void Testcategory()
        {

        }

        [Test, Microsoft.VisualStudio.TestTools.UnitTesting.Priority(2)]
        public void Prioritytest2()
        {
            int s = 16;
            double expected = 4;
            double actual = c.GetSqrt(s);
            Assert.GreaterOrEqual(s, expected);
            Assert.Less(expected, s);

        }

        [Test, Microsoft.VisualStudio.TestTools.UnitTesting.Priority(1)]
        public void Prioritytest1()
        {
            var obj1 = new object();
            var obj2 = obj1;
            Assert.AreSame(obj1, obj2);
            Assert.IsTrue(true);
            Assert.IsNotNull(obj2);
        }

        [Test, Ignore("ignored test")]
        public void TestIgnore()
        {
            //this test will not run
            int x = 0; int y = 3;
            int expected = 9;
            int actual = c.Sum(x, y);
            Assert.AreNotEqual(expected, actual);

        }

        [Test]
        public void Test1()
        {
            int x = 10;
            int y = 20;
            int expected = 30;
            int actual = c.Sum(x, y);
            Assert.AreEqual(expected, actual);
            Assert.LessOrEqual(x, actual);
        }

        [Test]
        public void Test2()
        {
            double x = 5.6;
            double y = 30.9;
            double expected = 36.5;
            double actual = c.Residual(x, y);
            Assert.AreNotSame(expected, actual);

        }

        [Test]
        public void Test3()
        {
            var expected = new int[] { 1, 2, 3 };
            var actual = new int[] { 1, 3, 5 };
            Array.Sort(actual);
            Assert.AreNotEqual(expected, actual);
            Assert.IsFalse(false);
            Assert.IsNotEmpty(actual);

        }

        [Test, Microsoft.VisualStudio.TestTools.UnitTesting.Priority(3)]
        public void Prioritytest3()
        {
            Assert.Throws<ArgumentException>(c.MethodThatThrows);

            // Using an anonymous delegate
            Assert.Throws<ArgumentException>(
            delegate { throw new ArgumentException(); });

            // Using a Lambda expression
            Assert.Throws<ArgumentException>(
              () => { throw new ArgumentException(); });
        }
        [Test]
        public void test4()
        {
            string? obj3 = null;
            string obj4 = obj3;
            Assert.IsNull(obj4);
        }
        [Test]
        public void test5()
        {
            Assert.Ignore();
            Assert.Fail();//verification failed
            
        }
    }
}