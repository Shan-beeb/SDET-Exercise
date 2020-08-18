using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sdet.Exercise
{
    [TestClass]
    public class TestLongestWordInASentence
    {
        [TestMethod]
        [ExpectedException(typeof(Exception), "String cannot be null or empty")]
        public void NullTest()
        {
            string input = null;
            Word.GetTheLongestWord(input);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "String cannot be null or empty")]
        public void EmptyStringTest()
        {
            var input = string.Empty;
            Word.GetTheLongestWord(input);
        }

        [TestMethod]
        public void SingleStringTest()
        {
            const string input = "Beautiful";
            var output = Word.GetTheLongestWord(input);

            const string expectedWord = "Beautiful";
            const int lengthOfExpectedWord = 9;

            Assert.AreEqual(expectedWord, output.Content);
            Assert.AreEqual(lengthOfExpectedWord, output.Length);
        }

        //Assume there is only one longest word in a sentence.
        [DataTestMethod]
        [DataRow("The cow jumped over the moon.", "jumped", 6)]
        [DataRow("The greatest glory in living lies not in never falling, but in rising every time we fall", "greatest", 8)]
        [DataRow("If life were predictable it would cease to be life, and be without flavor.", "predictable", 11)]
        [DataRow("If you set your goals ridiculously high and it's a failure, you will fail above everyone else's success.", "ridiculously", 12)]
        public void MultiStringTest(string input,string expectedWord,int lengthOfExpectedWord)
        {
            var output = Word.GetTheLongestWord(input);
            Assert.AreEqual(expectedWord, output.Content);
            Assert.AreEqual(lengthOfExpectedWord, output.Length);
        }
    }
}