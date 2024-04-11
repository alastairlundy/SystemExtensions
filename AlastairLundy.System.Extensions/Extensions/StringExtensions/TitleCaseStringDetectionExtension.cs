using AlastairLundy.System.Extensions.BoolArrayExtensions;

namespace AlastairLundy.System.Extensions.StringExtensions
{
    public static class TitleCaseStringDetectionExtension
    {
        /// <summary>
        /// Checks whether a word is capitalized.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool IsWordTitleCase(this string word)
        {
            string[] letters = word.Split();
            bool[] letterCapitalization = new bool[letters.Length];

            letterCapitalization[0] = letters[0].IsUpperCaseLetter();
            
            for (int index = 1; index < letters.Length; index++)
            {
                letterCapitalization[index] = letters[index].IsLowerCaseLetter();
            }

            return letterCapitalization.IsAllTrue();
        }
    }
}