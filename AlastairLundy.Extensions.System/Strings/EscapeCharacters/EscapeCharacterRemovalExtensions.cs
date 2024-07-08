namespace AlastairLundy.Extensions.System.EscapeCharacters
{
    public static class EscapeCharacterRemovalExtensions
    {
        internal static readonly string[] EscapeChars = new[] { "\r", "\n", "\t", "\v", @"\c", @"\e", "\f", "\a", "\b", "\\", @"\NNN", @"\xHH"};

        /// <summary>
        /// Returns whether the string contains an Escape Character.
        /// </summary>
        /// <param name="str">The string to be searched.</param>
        /// <returns>whether the string contains an Escape Character</returns>
        public static bool ContainsEscapeCharacters(this string str)
        {
            foreach (string escapeChar in EscapeChars)
            {
                if (str.Contains(escapeChar))
                {
                    return true;
                }
            }

            return false;
        }
        
        /// <summary>
        /// Removes escape characters from a string.
        /// </summary>
        /// <param name="str">The string to be modified.</param>
        public static string RemoveEscapeCharacters(this string str)
        {
            string newStr = str;
                
            if (ContainsEscapeCharacters(str))
            {
                foreach (string escapeChar in EscapeChars)
                {
                    if (newStr.Contains(escapeChar))
                    {
                        newStr = newStr.Replace(escapeChar, string.Empty);
                    }
                }
            }

            return newStr;
        }
    }
}