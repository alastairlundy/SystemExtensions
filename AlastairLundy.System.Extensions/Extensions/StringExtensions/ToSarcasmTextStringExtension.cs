using AlastairLundy.System.Extensions.StringArrayExtensions;

namespace AlastairLundy.System.Extensions.StringExtensions
{
    public static class ToSarcasmTextStringExtension
    {
        public static string ToSarcasmText(this string word)
        {
            return new string[] { word }.ToSarcasmText();
        }
    }
}