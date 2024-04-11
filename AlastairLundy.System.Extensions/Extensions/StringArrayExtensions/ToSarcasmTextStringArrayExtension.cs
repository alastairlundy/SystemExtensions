using System.Text;

namespace AlastairLundy.System.Extensions.StringArrayExtensions
{
    public static class ToSarcasmTextStringArrayExtension
    {
        /// <summary>
        /// Takes an array of ordinary words and converts each one to sArCaSm Text.
        /// </summary>
        public static string ToSarcasmText(this string[] words)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var word in words)
            {
                char[] chars = word.ToCharArray();

                for (int index = 0; index < chars.Length; index++)
                {
                    if((index % 2) == 0)
                    {
                        stringBuilder.Append(chars[index].ToString().ToUpper());
                    }
                    else
                    {
                        stringBuilder.Append(chars[index].ToString().ToLower());
                    }
                }
            }

            return stringBuilder.ToString();
        }
    }
}