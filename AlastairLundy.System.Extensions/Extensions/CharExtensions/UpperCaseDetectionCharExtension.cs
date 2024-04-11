using AlastairLundy.System.Extensions.StringExtensions;

namespace AlastairLundy.System.Extensions.CharExtensions
{
    public static class UpperCaseDetectionCharExtension
    {
        /// <summary>
        /// Returns whether a character is an upper case letter or not.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsUpperCaseLetter(this char c)
        {
            return c.ToString().IsUpperCaseLetter();
        }
    }
}