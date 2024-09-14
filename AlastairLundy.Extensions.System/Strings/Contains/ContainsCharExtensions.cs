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

namespace AlastairLundy.Extensions.System;

public static class ContainsCharExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="source">The string to be searched for.</param>
    /// <param name="c">The character to search for.</param>
    /// <returns>True if the string contains the specified char; False otherwise.</returns>
    public static bool Contains(this string source, char c)
    {
        return Contains(source, c, false);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="source">The string to be searched.</param>
    /// <param name="c">The character to search for.</param>
    /// <param name="ignoreCase">Whether to ignore the case of the char.</param>
    /// <returns>True if the string contains the specified char; False otherwise.</returns>
    public static bool Contains(this string source, char c, bool ignoreCase)
    {
        foreach (char ch in source)
        {
            if (ignoreCase == false)
            {
                if (ch.ToString().ToLower().Equals(c.ToString().ToLower()))
                {
                    return true;
                }
            }
            else
            {
                if (ch == c)
                {
                    return true;
                }
            }
        }

        return false;
    }
}