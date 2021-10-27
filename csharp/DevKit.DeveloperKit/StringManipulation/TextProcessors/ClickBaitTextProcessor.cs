/* BSD 3-Clause License
    
    Copyright (c) 2020-2021, AluminiumTech DevKit
    All rights reserved.
    
    Redistribution and use in source and binary forms, with or without
    modification, are permitted provided that the following conditions are met:
    
    1. Redistributions of source code must retain the above copyright notice, this
       list of conditions and the following disclaimer.
    
    2. Redistributions in binary form must reproduce the above copyright notice,
       this list of conditions and the following disclaimer in the documentation
       and/or other materials provided with the distribution.
    
    3. Neither the name of the copyright holder nor the names of its
       contributors may be used to endorse or promote products derived from
       this software without specific prior written permission.
    
    THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
    AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
    IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
    DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
    FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
    DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
    SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
    CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
    OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
    OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
    */

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