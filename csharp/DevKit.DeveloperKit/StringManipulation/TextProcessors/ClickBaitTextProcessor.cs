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

using AluminiumVision.BusinessLogic;

namespace AluminiumTech.DevKit.DeveloperKit.StringManipulation.TextProcessors
{
    /// <summary>
    /// 
    /// </summary>
    public class ClickBaitTextProcessor : GenericStringProcessor
    {
        public ClickBaitTextProcessor()
        {
            
        }
            
      
        public string BasicClickBaitCreation(string phrase, bool checkForBasicClickBait = true)
        {
            if (checkForBasicClickBait)
            {
                bool isClickBait = BasicClickBaitDetection(phrase);

                if (isClickBait)
                {
                    return phrase;
                }
            }

            return PhraseToTitleCase(phrase);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns></returns>
        public bool BasicClickBaitDetection(string phrase)
        {
            string[] words = phrase.Split();
            bool[] wordCapitalization = new bool[words.Length];

            for (int index = 1; index < words.Length; index++)
            {
                string word = words[index];
                wordCapitalization[index] = IsCharacterAnUpperCaseLetter(word[0]);
            }

            foreach (bool b in wordCapitalization)
            {
                if (b.Equals(true))
                {
                    return true;
                }
                else
                {
                    //Do nothing.
                }
            }

            return false;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="phrase"></param>
        /// <param name="checkForBasicClickBait"></param>
        /// <returns></returns>
        public string RemoveClickBait(string phrase, bool checkForBasicClickBait = true)
        {
            if (checkForBasicClickBait)
            {
                bool isClickBait = BasicClickBaitDetection(phrase);

                if (!isClickBait)
                {
                    return phrase;
                }
            }
            
            string[] words = phrase.Split();
            phrase = CapitalizeFirstLetter(words[0]);

            for (int index = 1; index < words.Length; index++) 
            {
                phrase += words[index].ToLower();
            }
            
            return phrase;
        }
    }
}