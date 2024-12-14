/*
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

namespace AlastairLundy.Extensions.Dates.DateOnly
{
    public static class DateOnlySubtractionExtensions
    {
#if NET6_0_OR_GREATER

        /// <summary>
        /// Subtract a specified amount of days from a DateOnly object.
        /// </summary>
        /// <param name="dateOnly">The DateOnly object to be subtracted from.</param>
        /// <param name="days">The amount of days to subtract from the specified DateOnly object.</param>
        /// <returns>the modified DateOnly object.</returns>
        public static System.DateOnly SubtractDays(this System.DateOnly dateOnly, int days)
        {
            DateTime fromDate = dateOnly.ToDateTime().SubtractDays(Convert.ToDouble(days));
            return System.DateOnly.FromDateTime(fromDate);
        }

        /// <summary>
        /// Subtract a specified amount of months from a DateOnly object.
        /// </summary>
        /// <param name="dateOnly">The DateOnly object to be subtracted from.</param>
        /// <param name="months">The amount of months to subtract from the specified DateOnly.</param>
        /// <returns>the modified DateOnly object.</returns>
        public static System.DateOnly SubtractMonths(this System.DateOnly dateOnly, int months)
        {
            DateTime result = dateOnly.ToDateTime().SubtractMonths(Convert.ToDouble(months));
            return System.DateOnly.FromDateTime(result);
        }

        /// <summary>
        /// Subtract a specified amount of years from a DateOnly object.
        /// </summary>
        /// <param name="dateOnly">The DateOnly object to be subtracted from.</param>
        /// <param name="years">The amount of years to subtract from the specified DateOnly object.</param>
        /// <returns>the modified DateOnly object.</returns>
        public static System.DateOnly SubtractYears(this System.DateOnly dateOnly, int years)
        {
            DateTime result = dateOnly.ToDateTime().SubtractYears(Convert.ToDouble(years));
            return System.DateOnly.FromDateTime(result);
        }
#endif   
    }
}