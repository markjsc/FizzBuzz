using System.Collections.Generic;
using System.Linq;
using FizzBuzz.API;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class NewFizzBuzzerTests
    {
        [Test]
        public void DoesFizzBuzzReturnFizzBuzzKablamWhenCounterIs15()
        {
            //Arrange
            const int UpperBound = 15;
            var actionValues = new Dictionary<int, string>
            {
                { 3, "Hound" },
                { 5, "Or" },
                { 15, "Mountain?" }
            };

            //Act
            var output = SuperFizzBuzzer.FizzBuzz(UpperBound, actionValues);

            //Assert
            var lastItem = output.Last();
            Assert.AreEqual("HoundOrMountain?", lastItem);
        }

        [Test]
        public void DoesFizzBuzzReturnNumberOfItemsMatchingUpperBound()
        {
            //Arrange
            const int UpperBound = 101;
            var actionValues = new Dictionary<int, string>();

            //Act
            var output = SuperFizzBuzzer.FizzBuzz(UpperBound, actionValues);

            //Assert
            Assert.AreEqual(UpperBound, output.Count());
        }

        [Test]
        public void DoesFizzBuzzShowAnExpectedSingleItemAtExpectedInterval()
        {
            //Arrange
            const int UpperBound = 12;
            const string FirstWord = "Tyrion";
            var actionValues = new Dictionary<int, string>()
            {
                { 3, FirstWord }
            };

            //Act
            var output = SuperFizzBuzzer.FizzBuzz(UpperBound, actionValues);

            //Assert
            Assert.AreEqual(FirstWord, output.Skip(2).First());
            Assert.AreEqual(FirstWord, output.Skip(5).First());
            Assert.AreEqual(FirstWord, output.Skip(8).First());
            Assert.AreEqual(FirstWord, output.Skip(11).First());
        }

        [Test]
        public void DoesFizzBuzzShowAnExpectedSecondWordAtTheExpectedInterval()
        {
            //Arrange
            const int UpperBound = 25;
            const string SecondWord = "Lannister";
            var actionValues = new Dictionary<int, string>()
            {
                { 4, "Tyrion" },
                { 5, SecondWord }
            };
            

            //Act
            var output = SuperFizzBuzzer.FizzBuzz(UpperBound, actionValues);

            //Assert
            Assert.AreEqual(SecondWord, output.Skip(4).First());
            Assert.AreEqual(SecondWord, output.Skip(9).First());
            Assert.AreEqual(SecondWord, output.Skip(14).First());
            Assert.AreEqual(SecondWord, output.Skip(24).First());
        }

        [Test]
        public void DoesFizzBuzzShowCombinationOfTwoWords()
        {
            //Arrange
            const int UpperBound = 30;
            const string FirstWord = "Jon";
            const string SecondWord = "Snow";
            var CombinedWords = $"{FirstWord}{SecondWord}";
            var actionValues = new Dictionary<int, string>()
            {
                { 3, FirstWord },
                { 5, SecondWord }
            };

            //Act
            var output = SuperFizzBuzzer.FizzBuzz(UpperBound, actionValues);

            //Assert
            Assert.AreEqual(CombinedWords, output.Skip(14).First());
            Assert.AreEqual(CombinedWords, output.Skip(29).First());
        }

        [Test]
        public void DoesFizzBuzzShowCombinationOfThreeWords()
        {
            //Arrange
            const int UpperBound = 30;
            const string FirstWord = "Poor";
            const string SecondWord = "Ned";
            const string ThirdWord = "Stark";
            var CombinedWords = $"{FirstWord}{SecondWord}{ThirdWord}";
            var actionValues = new Dictionary<int, string>()
            {
                { 3, FirstWord },
                { 5, SecondWord },
                { 15, ThirdWord }
            };

            //Act
            var output = SuperFizzBuzzer.FizzBuzz(UpperBound, actionValues);

            //Assert
            Assert.AreEqual(CombinedWords, output.Skip(14).First());
            Assert.AreEqual(CombinedWords, output.Skip(29).First());
        }

        [Test]
        public void DoesFizzBuzzShowNumberWhenNotOneOfTheCombinations()
        {
            //Arrange
            const int UpperBound = 15;
            const string FirstWord = "Cersei";
            const string SecondWord = "Jamie";
            const string ThirdWord = "Lannister";
            var actionValues = new Dictionary<int, string>()
            {
                { 3, FirstWord },
                { 5, SecondWord },
                { 15, ThirdWord }
            };

            //Act
            var output = SuperFizzBuzzer.FizzBuzz(UpperBound, actionValues);

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