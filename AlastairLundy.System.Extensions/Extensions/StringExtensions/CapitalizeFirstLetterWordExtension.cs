namespace AlastairLundy.System.Extensions.StringExtensions
{
    public static class CapitalizeFirstLetterWordExtension
    {
                
        /// <summary>
        /// Capitalizes the first letter in a word.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string CapitalizeFirstLetter(this string word)
        {
            return word.CapitalizeALetterInAWord(0);
        }
    }
}