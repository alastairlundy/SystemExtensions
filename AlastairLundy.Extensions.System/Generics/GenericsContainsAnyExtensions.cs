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
using System.Reflection;

namespace AlastairLundy.Extensions.System.Generics;

public static class GenericsContainsAnyExtensions
{
    /// <summary>
    /// Returns whether an item of type T contains any of a range of possible values
    /// </summary>
    /// <param name="source"></param>
    /// <param name="possibleValues"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static bool ContainsAnyOf<T>(this T source, IEnumerable<T> possibleValues)
    {
        bool output = false;

        foreach (T possibleValue in possibleValues)
        {
            if (source.Equals(possibleValue))
            {
                output = true;
            }

            bool hasContainsMethod = typeof(T).GetMember("Contains").Any();
            
            if (hasContainsMethod == true)
            {
                bool result;

                try
                {
                    result = (bool)typeof(T)!.InvokeMember("Contains",
                        BindingFlags.Public | BindingFlags.Static | BindingFlags.InvokeMethod, null, possibleValue,
                        new object[] { source })!;

                    if (result == true)
                    {
                        output = true;
                    }
                }
                catch
                {
                    
                }
            }
        }
        
        return output;
    }
}