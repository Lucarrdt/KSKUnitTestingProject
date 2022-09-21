using NUnit.Framework;
using ResistanceColor;

namespace TestColorToValue
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestColorToValue1()
        {
            string color = "red orange violet black";
            int val = 237;

            int result = Program.ColorToValue(color);

            Assert.AreEqual(val, result);
        }

        [Test]
        public void TestColorToValue2()
        {
            string color = "green blue black orange";
            int val = 560000;

            int result = Program.ColorToValue(color);

            Assert.AreEqual(val, result);
        }

        [Test]
        public void TestColorToValue3()
        {
            string color = "orange violet red brown";
            int val = 3720;

            int result = Program.ColorToValue(color);

            Assert.AreEqual(val, result);
        }


        [Test]
        public void TestValueToColor1()
        {
            int val = 4520;
            string color = "yellow green red brown";

            string result = Program.ValueToColor(val);

            Assert.AreEqual(color, result);
        }

        [Test]
        public void TestValueToColor2()
        {
            int val = 87300;
            string color = "grey violet orange red";

            string result = Program.ValueToColor(val);

            Assert.AreEqual(color, result);
        }

        [Test]
        public void TestValueToColor3()
        {
            int val = 4520;
            string color = "yellow green red brown";

            string result = Program.ValueToColor(val);

            Assert.AreEqual(color, result);
        }


    }
}