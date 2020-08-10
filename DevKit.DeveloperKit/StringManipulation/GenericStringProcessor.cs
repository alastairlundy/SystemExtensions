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

namespace AluminiumTech.DevKit.DeveloperKit.StringManipulation
{
    /// <summary>
    /// 
    /// </summary>
    public class GenericStringProcessor
    {
        public readonly string[] AlphabetLower = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        public readonly string[] SpecialCharacters = { "!", "#", "~", "_", "=", "(", ")", "%", "$", ";", ":", "{", "}", "[", "]" };
        
        /// <summary>
        /// Returns whether a character is an upper case letter or not.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool IsCharacterAnUpperCaseLetter(char c)
        {
            foreach (string s in AlphabetLower)
            {
                if (c.ToString().Equals(s.ToUpper()))
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
        /// Returns whether or not a character is a lower case letter or not.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool IsCharacterALowerCaseLetter(char c)
        {
            foreach (string s in AlphabetLower){
                if (c.ToString().Equals(s.ToLower()))
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