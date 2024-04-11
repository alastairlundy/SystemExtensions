namespace AlastairLundy.System.Extensions.StringExtensions
{
    public static class LowerCaseStringDetectionExtension
    {
        /// <summary>
        /// Returns whether a character, represented by a string, is a lower case letter or not.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsLowerCaseLetter(this string s)
        {
            string[] englishAlphabetLower =
            {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u",
                "v", "w", "x", "y", "z"
            };
            
            foreach (string abc in englishAlphabetLower){
                if (abc.Equals(s.ToLower()))
                {
                    //Get out of the for loop if the character matches.
                    return true;
                }
                else
                {
                    //Do nothing if it's not a match;
                }
            }

            return false;
        }
    }
}