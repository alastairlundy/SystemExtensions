using System.Text;
using AlastairLundy.System.Extensions.StringExtensions;

namespace AlastairLundy.System.Extensions.StringArrayExtensions
{
    public static class FromSarcasticTextStringArrayExtension
    {
        public static string FromSarcasmTextToRegularText(this string[] words)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(words[0].CapitalizeFirstLetter());
            
            for(int index = 1; index < words.Length; index++)
            {
                stringBuilder.Append(words[index]);
            }

            return stringBuilder.ToString();
        }
    }
}