using typograph;

namespace typographTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var methods = new Methods();
            string input = "Hello    world";
            string expectedOutput = "Hello world";
            string actualOutput = methods.RemovingSpace(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var methods = new Methods();
            string input = "(+,-)";
            string expectedOutput = "±";
            string actualOutput = methods.PlusMinus(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var methods = new Methods();
            string input = "...";
            string expectedOutput = "…";
            string actualOutput = methods.Ellipses(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var methods = new Methods();
            string input = "\"\"";
            string expectedOutput = "«»";
            string actualOutput = methods.Quotes(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var methods = new Methods();
            string input = "-";
            string expectedOutput = "-";
            string actualOutput = methods.DashToMinus(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var methods = new Methods();
            string input = "1+2-3";
            string expectedOutput = "1 + 2 - 3";
            string actualOutput = methods.SpacesAroundPlusMinus(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var methods = new Methods();
            string input = "1=1";
            string expectedOutput = "1 = 1";
            string actualOutput = methods.SpacesAroundEqual(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestMethod8()
        {
            var methods = new Methods();
            string input = "1*2/3";
            string expectedOutput = "1 * 2 / 3";
            string actualOutput = methods.SpacesAroundMultilyDivision(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestMethod9()
        {
            var methods = new Methods();
            string input = ",,";
            string expectedOutput = ",";
            string actualOutput = methods.ExtraCommas(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestMethod10()
        {
            var methods = new Methods();
            string input = "12345";
            string expectedOutput = "|12345";
            string actualOutput = methods.Absurdity(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}