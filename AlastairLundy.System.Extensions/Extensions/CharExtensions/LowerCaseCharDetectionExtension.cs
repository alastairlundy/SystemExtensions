using AlastairLundy.System.Extensions.StringExtensions;

namespace AlastairLundy.System.Extensions.CharExtensions
{
    public static class LowerCaseCharDetectionExtension
    {
        /// <summary>
        /// Returns whether a character is a lower case letter or not.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsCharacterALowerCaseLetter(this char c)
        {
            return c.ToString().IsLowerCaseLetter();
        }
    }
}