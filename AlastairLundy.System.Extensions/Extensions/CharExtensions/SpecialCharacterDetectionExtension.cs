namespace AlastairLundy.System.Extensions.CharExtensions
{
    public static class SpecialCharacterDetectionExtension
    {
        /// <summary>
        /// Returns whether a character is a special character or not.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsSpecialCharacter(this char c)
        {
            string[] specialCharacters =
                {"!", "#", "~", "_", "=", "(", ")", "%", "$", ";", ":", "{", "}", "[", "]"};
            
            foreach (string s in specialCharacters)
            {
                
                if (c.ToString().Equals(s))
                {
                    
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}