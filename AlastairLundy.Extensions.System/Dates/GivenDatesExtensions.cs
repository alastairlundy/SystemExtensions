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

using System;

namespace AlastairLundy.Extensions.System.Dates;

public static class GivenDatesExtensions
{
    /// <summary>
    /// `
    /// </summary>
    /// <param name="dateString"></param>
    /// <returns></returns>
    public static string GivenDateToString(this string dateString)
    {
        return DateTime.Parse(dateString).GivenDateToString();
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="dateString"></param>
    /// <param name="result"></param>
    /// <returns></returns>
    public static bool TryParseGivenDate(this string dateString, out string? result)
    {
        try
        {
            result = GivenDateToString(dateString);
            return true;
        }
        catch
        {
            result = null;
            return false;
        }
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public static string GivenDateToString(this DateTime date)
    {
        return date.ToString("R");
    }
}