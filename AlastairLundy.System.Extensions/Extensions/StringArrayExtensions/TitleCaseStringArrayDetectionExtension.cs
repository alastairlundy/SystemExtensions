using AlastairLundy.System.Extensions.BoolArrayExtensions;
using AlastairLundy.System.Extensions.StringExtensions;

namespace AlastairLundy.System.Extensions.StringArrayExtensions
{
    public static class TitleCaseStringArrayDetectionExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns></returns>
        public static bool IsTitleCase(this string phrase)
        {
            var words = phrase.Split();
            
            bool[] results = new bool[words.Length];
            
            for (int index = 0; index < words.Length; index++)
            {
                results[index] = words[index].IsWordTitleCase();
            }
            
            return results.IsAllTrue();
        }
    }
}