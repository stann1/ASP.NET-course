using System;
using System.Linq;
using NUnit.Framework;

namespace Tests
{
    public class UtilsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WordCount_WithManyWords_ReturnsCorrectNumber()
        {
            string sentence = "I am Gosho Petkov";
            int result = sentence.WordCount();

            Assert.AreEqual(4, result);
        }

        [Test]
        public void WordCount_WithOneWord_ReturnsCorrectNumber()
        {
            string sentence = "word";
            int result = sentence.WordCount();

            Assert.AreEqual(1, result);
        }

        [Test]
        public void WordCount_UsingWordsWithSpecialChars_ReturnsCorrectNumber()
        {
            string sentence = "first?second";
            int result = sentence.WordCount();

            Assert.AreEqual(2, result);
        }

        [Test]
        public void GetOddNumbers_UsingValidCollection_ReturnsCorrectNumbers()
        {
            // arrange
            var numbers = new int[] {1,2,3,4,5};
            
            // act
            var results = Utils.GetOddNumbers(numbers).ToList<int>();
            
            // assert
            Assert.AreEqual(3, results.Count);
        }

        [Test]
        public void GetOddNumbers_UsingEmptyCollection_ThrowsError()
        {
            // arrange
            var numbers = new int[] {};
            
            // assert
            Assert.Throws<ArgumentNullException>(() => Utils.GetOddNumbers(numbers));
        }
    }
}