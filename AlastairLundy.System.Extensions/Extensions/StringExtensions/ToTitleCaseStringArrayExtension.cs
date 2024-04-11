using System.Text;

namespace AlastairLundy.System.Extensions.StringExtensions
{
    public static class ToTitleCaseStringArrayExtension
    {
        /// <summary>
        /// Turns a regular string to a Title Case String Like This.
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string ToTitleCase(this string[] words)
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            for (int index = 0; index < words.Length; index++)
            {
                if (words[index].IsWordTitleCase())
                {
                    stringBuilder.Append(words[index]);
                }
                else
                {
                    stringBuilder.Append(words[index].CapitalizeFirstLetter());
                }
            }

            return stringBuilder.ToString();
        }
    }
}