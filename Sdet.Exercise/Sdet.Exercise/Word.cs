using System;

namespace Sdet.Exercise
{
    public class Word
    {
        public int Length { get; private set; }
        public string Content { get; private set; }

        
        /// <summary>
        /// Returns biggest/longest word from a sentence.
        /// Assume there is only one longest word in a sentence.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static Word GetTheLongestWord(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new Exception("String cannot be null or empty");

            var words = input.Split(' ');
            var biggestWord = string.Empty;
            var indexOfBiggestWord = 0;

            for (var currentIndex = 0; currentIndex < words.Length; currentIndex++)
            {
                if (biggestWord.Length >= words[currentIndex].Length) continue;
                biggestWord = words[currentIndex];
                indexOfBiggestWord = currentIndex;
            }

            return new Word
            {
                Content = biggestWord,
                Length = indexOfBiggestWord
            };

        }
    }
}