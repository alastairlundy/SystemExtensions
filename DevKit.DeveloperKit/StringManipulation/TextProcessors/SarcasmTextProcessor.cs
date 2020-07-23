/*
MIT License

Copyright (c) AluminiumTech 2018-2020

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
    */

using System.Collections.Generic;

namespace AluminiumTech.DevKit.DeveloperKit.StringManipulation.TextProcessors
{
    public class SarcasmTextProcessor : GenericStringProcessor
    {

        public SarcasmTextProcessor()
        {
            
        }
        
        /// <summary>
        /// Takes a word in sArCaSm Text and converts it back into regular text.
        /// </summary>
        /// <param name="sarcasmText"></param>
        /// <returns></returns>
        public string ConvertSarcasmWordToRegularText(string sarcasmText)
        {
            return CapitalizeFirstLetter(sarcasmText);
        }
        
        /// <summary>
        /// Takes an array of sArCaSm Text and converts each word back into regular text.
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public string[] ConvertSarcasmPhraseToRegularText(string[] words)
        {
            string result = "";
            foreach (string word in words)
            { 
                result += word;
            }

            return ConvertSarcasmWordToRegularText(result).Split(' ');
        }
        
        /// <summary>
        /// Takes an ordinary word and converts it to sArCaSm Text.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public string ConvertWordToSarcasmText(string word)
        {
            string result = "";

            char[] chars = word.ToCharArray();

            for (int index = 0; index < chars.Length; index++)
            {
                if((index % 2) == 0)
                {
                    result += chars[index].ToString().ToUpper();
                }
                else
                {
                    result += chars[index].ToString().ToLower();
                }
            }

            return result;
        }
        
        /// <summary>
        /// Takes an array of ordinary words and converts each one to sArCaSm Text.
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns></returns>
        public string[] ConvertPhraseToSarcasmText(string[] phrase)
        {
            List<string> listOfWords = new List<string>();
            foreach (string word in phrase)
            {
                listOfWords.Add(ConvertWordToSarcasmText(word));
            }

            return listOfWords.ToArray();
        }
    }
}