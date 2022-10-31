using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {

        private float result = 0.0f;
        // A Test behaves as an ordinary method
        [Test]
        public void TestSuiteSimplePasses()
        {
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }
        [Test]
        public void TestSuiteSimplePasses2()
        {
            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }
        [Test]
        public void TestSuiteSimplePasses3()
        {
            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);
        }
        [Test]
        public void TestSuiteSimplePasses4()
        {
            result = Calculator.CalculatePair(10, 2, "/");
            Assert.AreEqual(result, 5);
        }
        [Test]
        public void TestSuiteSimplePasses5()
        {
            result = Calculator.CalculatePair(5, 2, "^");
            Assert.AreEqual(result, 25);
        }
        [Test]
        public void TestSuiteSimplePasses6()
        {
            result = Calculator.CalculatePair(25, 0, "√");
            Assert.AreEqual(result, 5);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestSuiteWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;

            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);

            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);

            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);

            result = Calculator.CalculatePair(10, 2, "/");
            Assert.AreEqual(result, 5);

            result = Calculator.CalculatePair(5, 2, "^");
            Assert.AreEqual(result, 25);

            result = Calculator.CalculatePair(25, 0, "√");
            Assert.AreEqual(result, 5);
        }
    }
}
