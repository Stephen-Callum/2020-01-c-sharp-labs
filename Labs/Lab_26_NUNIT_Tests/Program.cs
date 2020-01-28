using System;
using NUnit;
using NUnit.Framework;
using Lab_27_TestEdition;
using Lab_28_TestPractice;

namespace Lab_26_NUNIT_Tests
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //create code for live demo
        //}
    }

    class NUnit_Tests
    {
        // create uniform testin environment - perhaps load startup info from database
        [SetUp]
        public void Setup()
        {

        }

        [TestCase(1,2,3)]
        [TestCase(3,6,9)]
        [TestCase(5,7,12)]
        [TestCase(2,2,4)]
        [TestCase(1000,2000,3000)]
        public void TestAdditionDemo(int a, int b, int expected)
        {
            // Arrange - set up test ready to run
            //         - create instances of test classes
            var instance = new Addition();

            // Act     - run code to get 'actual' value
            var actual = instance.AddTwoNumbers(a, b);
            // Assert  - assert.AreEqual(actual,expected);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,2,2)]
        public void Sum_2D_Array_Test(int numrows, int numcolumns, int expected)
        {
            // Arrange
            var instance = new Basic_Tests();

            // Act
            var actual = instance.Test_100_Sum_2D_Array(numrows, numcolumns);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 2, 2, 4)]
        public void Test_120_Sum_3D_Cube(int numrows, int numcolumns, int z, int expected)
        {
            // Arrange
            var instance = new Basic_Tests();

            // Act
            var actual = instance.Test_120_Sum_3D_Cube(numrows, numcolumns, z);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0,0,0,0)]
        [TestCase(2,2,2,1)]
        [TestCase(3,3,3,27)]
        [TestCase(4,4,4,216)]
        public void Warm_Up_3D_Array(int x, int y, int z, int expected)
        {
            // Arrange
            var instance = new Basic_Tests();

            // Act
            var actual = instance.Warm_Up_3D_Array(x, y, z);
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
