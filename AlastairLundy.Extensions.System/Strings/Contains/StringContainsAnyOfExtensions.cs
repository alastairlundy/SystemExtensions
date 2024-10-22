﻿/*
        MIT License
       
       Copyright (c) 2024 Alastair Lundy
       
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
using System.Linq;

namespace AlastairLundy.Extensions.System.Strings.Contains;

public static class StringContainsAnyOfExtensions
{
    
    /// <summary>
    /// Returns whether an item of type T contains any of the specified possible values
    /// </summary>
    /// <param name="source">The item to be searched.</param>
    /// <param name="possibleValues">The possible values to search for.</param>
    /// <returns>true if any of possibles values is found; returns false otherwise.</returns>
    public static bool ContainsAnyOf(this string source, IEnumerable<string> possibleValues)
    {
        string[] vals = possibleValues.ToArray();
        KeyValuePair<string, bool>[] pairs = new KeyValuePair<string, bool>[vals.Length];

        for(int index = 0; index < pairs.Length; index++)
        {
            pairs[index] = new KeyValuePair<string, bool>(vals[index], source.Contains(vals[index]));
        }

        return pairs.Any(pair => pair.Value == true);
    }
}