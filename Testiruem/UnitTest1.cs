

using ClassLibrary1;

namespace Testiruem
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Primer()
        {
            int a = 0;
            int b = 0;
            int expected = 0;
            Class1 c = new Class1();
            int actual = c.MathTentakli(a,b);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void ProverkaNaNull()
        {
            int a = 10;
            int b = 20;
            int expected = 30;
            Class1 c = new Class1();
            int actual = c.MathTentakli(a, b);
            Assert.NotNull(expected);

        }
        [Test]
        public void ProverkaNaZero ()
        {
            int a = 30;
            int b = 40;
            int expected = 70;
            Class1 c = new Class1();
            int actual = c.MathTentakli(a, b);
            Assert.NotZero(expected);

        }
        [Test]
        public void ProverkaNaMinus()
        {
            int a = -10;
            int b = -5;
            int expected = -5;
            Class1 c = new Class1();
            int actual = c.MathTentakli(a, b);
            Assert.Negative(actual);

        }
    }
}