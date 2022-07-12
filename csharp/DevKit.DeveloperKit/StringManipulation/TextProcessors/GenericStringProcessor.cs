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

namespace AluminiumTech.DeveloperKit.StringManipulation.TextProcessors
{
    /// <summary>
    /// 
    /// </summary>
    public class GenericStringProcessor
    {

        protected readonly InputAveraging inputAveraging;
        
        public GenericStringProcessor()
        {
            inputAveraging = new InputAveraging();
        }
        
        /// <summary>
        /// 
        /// </summary>
        public readonly string[] EnglishAlphabetLower =
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u",
            "v", "w", "x", "y", "z"
        };
        /// <summary>
        /// 
        /// </summary>
        public readonly string[] SpecialCharacters =
            {"!", "#", "~", "_", "=", "(", ")", "%", "$", ";", ":", "{", "}", "[", "]"};

        /// <summary>
        /// Turns a regular string to a Title Case String Like This.
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns></returns>
        public string PhraseToTitleCase(string phrase)
        {
            var words = phrase.Split();
            phrase = "";
            
            for (int index = 0; index < words.Length; index++)
            {
                if (IsWordTitleCase(words[index]))
                {
                    phrase += words[index];
                }
                else
                {
                    phrase += CapitalizeFirstLetter(words[index]);
                }
            }

            return phrase;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns></returns>
        public bool BasicTitleCaseDetection(string phrase)
        {
            var words = phrase.Split();
            
            bool[] results = new bool[words.Length];
            
            for (int index = 0; index < words.Length; index++)
            {
                results[index] = IsWordTitleCase(words[index]);
            }
            
            return inputAveraging.IsAllPositive(results);
        }

        /// <summary>
        /// Checks whether a word is capitalized or not.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool IsWordTitleCase(string word)
        {
            string[] letters = word.Split();
            bool[] letterCapitalization = new bool[letters.Length];

            letterCapitalization[0] = IsCharacterAnUpperCaseLetter(letters[0]);
            
            for (int index = 1; index < letters.Length; index++)
            {
                letterCapitalization[index] = IsCharacterALowerCaseLetter(letters[index]);
            }

            return inputAveraging.IsAllPositive(letterCapitalization);
        }
        
        /// <summary>
        /// Returns whether a character, represented as a string, is an upper case letter or not.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public bool IsCharacterAnUpperCaseLetter(string s)
        {
            foreach (string abc in EnglishAlphabetLower)
            {
                if (abc.Equals(s.ToUpper()))
                {
                    //Get out of the for loop if it the character matches.
                    return true;
                }
                else
                {
                    //Do nothing if it's false.
                }
            }

            return false;
        }
        
        /// <summary>
        /// Returns whether a character is an upper case letter or not.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool IsCharacterAnUpperCaseLetter(char c)
        {
            return IsCharacterAnUpperCaseLetter(c.ToString());
        }
        
        /// <summary>
        /// Returns whether or not a character, represented by a string, is a lower case letter or not.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsCharacterALowerCaseLetter(string s)
        {
            foreach (string abc in EnglishAlphabetLower){
                if (abc.Equals(s.ToLower()))
                {
                    //Get out of the for loop if it the character matches.
                    return true;
                }
                else
                {
                    //Do nothing if it's not a match;
                }
            }

            return false;
        }
        
        /// <summary>
        /// Returns whether or not a character is a lower case letter or not.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool IsCharacterALowerCaseLetter(char c)
        {
            return IsCharacterALowerCaseLetter(c.ToString());
        }

        /// <summary>
        /// Returns whether or not a character is a special character or not.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool IsCharacterASpecialCharacter(char c)
        {
            foreach (string s in SpecialCharacters)
            {
                if (c.ToString().Equals(s))
                {
                    
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
        
        /// <summary>
        /// Capitalizes the specified letter in the word.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public string CapitalizeALetterInAWord(int index, string word)
        {
            string result = "";
            char[] chars = word.ToCharArray();
            
            for(int i = 0; i < chars.Length; i++)
            {
                if (i.Equals(index))
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
        /// Capitalizes the first letter in a word.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public string CapitalizeFirstLetter(string word)
        {
           return CapitalizeALetterInAWord(0, word);
        }
        
    }
}