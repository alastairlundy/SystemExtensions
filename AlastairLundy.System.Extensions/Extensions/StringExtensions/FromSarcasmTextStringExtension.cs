using AlastairLundy.System.Extensions.StringArrayExtensions;

namespace AlastairLundy.System.Extensions.StringExtensions
{
    public static class FromSarcasmTextStringExtension
    {
        public static string FromSarcasmTextToRegularText(this string word)
        {
            return new string[1] { word }.FromSarcasmTextToRegularText();
        }
    }
}