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

            foreach (var word in words)
            {
                if (biggestWord.Length >= word.Length) continue;
                biggestWord = word;
            }

            return new Word
            {
                Content = biggestWord,
                Length = biggestWord.Length
            };
        }
    }
}