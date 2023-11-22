using TesteoFizzBuzz;
using FizzBuzz;

namespace TesteoFizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PrintOneIfReceiveOne()
        {
            PruebaFizzBuzz pruebaFizzBuzz = new PruebaFizzBuzz();
            pruebaFizzBuzz.FizzBuzz(1);
        }

        [TestMethod]
        public void PrintFizzIfReceiveA3()
        {
            PruebaFizzBuzz pruebaFizzBuzz = new PruebaFizzBuzz();
            pruebaFizzBuzz.FizzBuzz(3);
        }

        [TestMethod]
        public void PrintFizzIfReceiveAMultiplyOf3()
        {
            PruebaFizzBuzz pruebaFizzBuzz = new PruebaFizzBuzz();
            pruebaFizzBuzz.FizzBuzz(3);
        }

        [TestMethod]
        public void PrintBuzzIfReceiveA5()
        {
            PruebaFizzBuzz pruebaFizzBuzz = new PruebaFizzBuzz();
            pruebaFizzBuzz.FizzBuzz(5);
        }

        [TestMethod]
        public void PrintBuzzIfReceiveAMultiplyOf5()
        {
            PruebaFizzBuzz pruebaFizzBuzz = new PruebaFizzBuzz();
            pruebaFizzBuzz.FizzBuzz(5);
        }

        [TestMethod]
        public void PrintFizzBuzzIfReceiveAMultiplyOf3and5()
        {
            PruebaFizzBuzz pruebaFizzBuzz = new PruebaFizzBuzz();
            pruebaFizzBuzz.FizzBuzz(15);
        }

        [TestMethod]
        public void EqualZero()
        {
            PruebaFizzBuzz pruebaFizzBuzz = new PruebaFizzBuzz();
            pruebaFizzBuzz.FizzBuzz(0);
        }

        [TestMethod]
        public void PrintNumber()
        {
            PruebaFizzBuzz pruebaFizzBuzz = new PruebaFizzBuzz();
            pruebaFizzBuzz.FizzBuzz(30);
        }

        [TestMethod]
        public void BiggerthanZero()
        {
            PruebaFizzBuzz pruebaFizzBuzz = new PruebaFizzBuzz();
            pruebaFizzBuzz.FizzBuzz(-25);
        }
    }
}