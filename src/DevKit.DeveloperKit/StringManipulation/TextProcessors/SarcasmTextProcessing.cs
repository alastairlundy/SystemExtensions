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

namespace AlastairLundy.DeveloperKit.StringManipulation.TextProcessors;

public class SarcasmTextProcessing
{
    protected GenericStringProcessor _genericStringProcessor;

    public SarcasmTextProcessing()
    {
        _genericStringProcessor = new GenericStringProcessor();
    }
    
    public string ConvertSarcasmTextToRegularText(string[] words)
    {
        var result = _genericStringProcessor.CapitalizeFirstLetter(words[0]);
            
        for(int index = 1; index < words.Length; index++)
        {
            result += words[index];
        }

        return result;
    }
    
    /// <summary>
    /// Takes an array of ordinary words and converts each one to sArCaSm Text.
    /// </summary>
    public string ConvertPhraseToSarcasmText(string[] words)
    {
        var result = "";

        foreach (var word in words)
        {
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
        }

        return result;
    }
}