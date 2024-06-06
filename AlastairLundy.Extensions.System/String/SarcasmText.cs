using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace AlastairLundy.Extensions.System.String
{
    public class SarcasmText
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        public static bool TryParse(string input, out string output)
        {
            try
            {
                output = Encode(input);
                return true;
            }
            catch
            {
                output = null;
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chars"></param>
        /// <returns></returns>
        public static IEnumerable<char> Encode(IEnumerable<char> chars)
        {
            char[] enumerable = chars as char[] ?? chars.ToArray();
            
            StringBuilder stringBuilder = new StringBuilder();
            
            for (int index = 0; index < enumerable.Count(); index++)
            {
                stringBuilder.Append(index % 2 == 0
                    ? enumerable[index].ToString().ToUpper()
                    : enumerable[index].ToString().ToLower());
            }

            return stringBuilder.ToString().ToCharArray();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string Encode(string word)
        {
            string[] words = word.Split(' ');

            StringBuilder stringBuilder = new StringBuilder();
            
            if (words.Length > 1)
            {
                foreach (string s in words)
                {
                    stringBuilder.Append(Encode(s.ToCharArray()).ToString());
                }
                
                return stringBuilder.ToString();
            }
            else
            {
                return Encode(word.ToCharArray()).ToString();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static IEnumerable<string> Encode(IEnumerable<string> words)
        {
            string[] enumerable = words as string[] ?? words.ToArray();

            List<string> newWords = new List<string>();

            foreach (string word in enumerable)
            {
                newWords.Add(Encode(word));
            }

            return newWords.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chars"></param>
        /// <returns></returns>
        public static IEnumerable<char> Decode(IEnumerable<char> chars)
        {
            char[] enumerable = chars as char[] ?? chars.ToArray();
            
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(char.Parse(enumerable[0].ToString().ToUpper()));
            
            for (int index = 1; index < enumerable.Count(); index++)
            {
                stringBuilder.Append(char.Parse(enumerable[index].ToString().ToLower()));
            }

            return stringBuilder.ToString().ToCharArray();
        }

    }
}