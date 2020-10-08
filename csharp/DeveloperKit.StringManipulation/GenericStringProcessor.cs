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

// ReSharper disable All

using AluminiumTech.DevKit.DeveloperKit.StringManipulation;

namespace AluminiumVision.BusinessLogic
{
    /// <summary>
    /// 
    /// </summary>
    public class GenericStringProcessor
    {

        protected ResultsAveraging resultsAveraging;
        
        public GenericStringProcessor()
        {
         resultsAveraging = new ResultsAveraging();
        }
        
        /// <summary>
        /// 
        /// </summary>
        public readonly string[] AlphabetLower =
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
        
        public bool BasicTitleCaseDetection(string phrase)
        {
            var words = phrase.Split();
            
            bool[] results = new bool[words.Length];
            
            for (int index = 0; index < words.Length; index++)
            {
                results[index] = IsWordTitleCase(words[index]);
            }
            
            return resultsAveraging.IsAllPositive(results);
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

            return resultsAveraging.IsAllNegative(letterCapitalization);
        }
        
        /// <summary>
        /// Returns whether a character, represented as a string, is an upper case letter or not.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public bool IsCharacterAnUpperCaseLetter(string s)
        {
            foreach (string abc in AlphabetLower)
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
            foreach (string abc in AlphabetLower){
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