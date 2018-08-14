using System.Linq;
using FizzBuzz.API;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    /// <summary>
    /// Note: These are bit brittle - i.e. using magic-values and 
    /// referencing specific items directly. In a larger system
    /// I would write some helper methods and refactor these to be
    /// a bit more clean and maintainable.
    /// </summary>
    [TestFixture]
    public class OriginalFizzBuzzerTests
    {
        [Test]
        public void DoesFizzBuzzReturnFizzBuzzWhenCounterIs15()
        {
            //Arrange
            const int UpperBound = 15;

            //Act
            var output = OriginalFizzBuzzer.FizzBuzz(UpperBound);

            //Assert
            var lastItem = output.Last();
            Assert.AreEqual("FizzBuzz", lastItem);
        }

        [Test]
        public void DoesFizzBuzzReturnNumberOfItemsMatchingUpperBound()
        {
            //Arrange
            const int UpperBound = 101;

            //Act
            var output = OriginalFizzBuzzer.FizzBuzz(UpperBound);

            //Assert
            Assert.AreEqual(UpperBound, output.Count());
        }

        /// <summary>
        /// This is a valid test, but takes a while to run...
        /// </summary>
        //[Test]
        //public void DoesFizzBuzzTakeIntMaxValue()
        //{
        //    //Arrange
        //    const int UpperBound = int.MaxValue;

        //    //Act
        //    var output = OriginalFizzBuzzer.FizzBuzz(UpperBound);

        //    //Assert
        //    Assert.AreEqual(UpperBound, output.Count());
        //}

        [Test]
        public void DoesFizzBuzzShowFizzOnMultiplesOfThree()
        {
            //Arrange
            const int UpperBound = 12;
            const string Fizz = "Fizz";

            //Act
            var output = OriginalFizzBuzzer.FizzBuzz(UpperBound);

            //Assert
            Assert.AreEqual(Fizz, output.Skip(2).First());
            Assert.AreEqual(Fizz, output.Skip(5).First());
            Assert.AreEqual(Fizz, output.Skip(8).First());
            Assert.AreEqual(Fizz, output.Skip(11).First());
        }

        [Test]
        public void DoesFizzBuzzShowBuzzOnMultiplesOfFive()
        {
            //Arrange
            const int UpperBound = 25;
            const string Buzz = "Buzz";

            //Act
            var output = OriginalFizzBuzzer.FizzBuzz(UpperBound);

            //Assert
            Assert.AreEqual(Buzz, output.Skip(4).First());
            Assert.AreEqual(Buzz, output.Skip(9).First());
            //Not covering 15 here - will cover that in a different test
            Assert.AreEqual(Buzz, output.Skip(19).First());
            Assert.AreEqual(Buzz, output.Skip(24).First());
        }

        [Test]
        public void DoesFizzBuzzShowFizzBuzzOnMultiplesOfThreeAndFive()
        {
            //Arrange
            const int UpperBound = 30;
            const string FizzBuzz = "FizzBuzz";

            //Act
            var output = OriginalFizzBuzzer.FizzBuzz(UpperBound);

            //Assert
            Assert.AreEqual(FizzBuzz, output.Skip(14).First());
            Assert.AreEqual(FizzBuzz, output.Skip(29).First());
        }

        [Test]
        public void DoesFizzBuzzShowNumberWhenNotThreeAndFive()
        {
            //Arrange
            const int UpperBound = 15;

            //Act
            var output = OriginalFizzBuzzer.FizzBuzz(UpperBound);

            //Assert
            Assert.AreEqual("1", output.First());
            Assert.AreEqual("2", output.Skip(1).First());
            Assert.AreEqual("4", output.Skip(3).First());
            Assert.AreEqual("7", output.Skip(6).First());
            Assert.AreEqual("8", output.Skip(7).First());
            Assert.AreEqual("11", output.Skip(10).First());
            Assert.AreEqual("13", output.Skip(12).First());
            Assert.AreEqual("14", output.Skip(13).First());
        }
    }
}
