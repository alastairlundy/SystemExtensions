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