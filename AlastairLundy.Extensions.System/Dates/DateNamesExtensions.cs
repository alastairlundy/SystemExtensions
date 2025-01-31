/*
        MIT License
       
       Copyright (c) 2020-2025 Alastair Lundy
       
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

namespace AlastairLundy.Extensions.System.Dates
{
    public static class DateNamesExtensions
    {
    
        /// <summary>
        /// Gets the short month name as a 3 character string.
        /// </summary>
        /// <param name="date">The dateTime object to be used.</param>
        /// <returns>the short month name as a 3 character string.</returns>
        public static string ShortMonthName(this DateTime date)
        {
            return date.ToString("MMM");
        }

        /// <summary>
        /// Gets the normal long month name as a string.
        /// </summary>
        /// <param name="date">The dateTime object to be used.</param>
        /// <returns>the long name of the month as a string.</returns>
        public static string LongMonthName(this DateTime date)
        {
            return date.ToString("MMMM");
        }

        /// <summary>
        /// Gets the full weekday name as a string.
        /// </summary>
        /// <param name="date">The dateTime to be used.</param>
        /// <returns>the full weekday name.</returns>
        public static string FullWeekDayName(this DateTime date)
        {
            return date.ToString("dddd");
        }

        /// <summary>
        /// Gets the short weekday name as a 3 or 4 character string.
        /// </summary>
        /// <param name="date">The dateTime to be used.</param>
        /// <returns>the 3-4 character weekday name as a string.</returns>
        public static string ShortWeekDayName(this DateTime date)
        {
            return date.ToString("ddd");
        }
    }
}