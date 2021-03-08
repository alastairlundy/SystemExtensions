/*
    DeveloperKit
    Copyright (C) 2021 AluminiumTech

    This library is free software; you can redistribute it and/or
    modify it under the terms of the GNU Lesser General Public
    License as published by the Free Software Foundation; either
    version 2.1 of the License, or (at your option) any later version.

    This library is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
    Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public
    License along with this library; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
    USA
    */

using AluminiumVision.BusinessLogic;

namespace AluminiumTech.DevKit.DeveloperKit.StringManipulation.TextProcessors
{
    /// <summary>
    /// 
    /// </summary>
    public class SarcasmTextProcessor : GenericStringProcessor
    {

        public SarcasmTextProcessor()
        {
            
        }
        
        /// <summary>
        /// Takes a series of words in sArCaSm Text and converts each word back into regular text.
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns></returns>
        public string ConvertSarcasmTextToRegularText(string phrase)
        {
            var words = phrase.Split();
            phrase = "";

            phrase += CapitalizeFirstLetter(words[0]);
            
            for(int index = 1; index < words.Length; index++)
            {
                phrase += words[index];
            }

            return phrase;
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
        public string ConvertPhraseToSarcasmText(string phrase)
        {
            var words = phrase.Split();
            phrase = "";
            
            for (int index = 0; index < words.Length; index++)
            {
                phrase += ConvertWordToSarcasmText(words[index]);
            }

            return phrase;
        }
    }
}