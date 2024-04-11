namespace AlastairLundy.System.Extensions.StringExtensions
{
    public static class UpperCaseStringDetectionExtension
    {
        /// <summary>
        /// Returns whether a character, represented as a string, is an upper case letter or not.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static bool IsUpperCaseLetter(this string s)
        {
            string[] englishAlphabetLower =
            {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u",
                "v", "w", "x", "y", "z"
            };
            
            foreach (string abc in englishAlphabetLower)
            {
                if (abc.Equals(s.ToUpper()))
                {
                    //Get out of the for loop if the character matches.
                    return true;
                }
            }

            return false;
        }
    }
}