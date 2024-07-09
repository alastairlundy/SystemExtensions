
using System;

namespace AlastairLundy.Extensions.System;
    public static class DateOnlySubtractionExtensions
    {
#if NET6_0_OR_GREATER

        /// <summary>
        /// Subtract a specified amount of days from a DateOnly object.
        /// </summary>
        /// <param name="dateOnly">The DateOnly object to be subtracted from.</param>
        /// <param name="days">The amount of days to subtract from the specified DateOnly object.</param>
        /// <returns>the modified DateOnly object.</returns>
        public static DateOnly SubtractDays(this DateOnly dateOnly, int days)
        {
            DateTime fromDate = dateOnly.ToDateTime().SubtractDays(Convert.ToDouble(days));
            return DateOnly.FromDateTime(fromDate);
        }

        /// <summary>
        /// Subtract a specified amount of months from a DateOnly object.
        /// </summary>
        /// <param name="dateOnly">The DateOnly object to be subtracted from.</param>
        /// <param name="months">The amount of months to subtract from the specified DateOnly.</param>
        /// <returns>the modified DateOnly object.</returns>
        public static DateOnly SubtractMonths(this DateOnly dateOnly, int months)
        {
            DateTime result = dateOnly.ToDateTime().SubtractMonths(Convert.ToDouble(months));
            return DateOnly.FromDateTime(result);
        }

        /// <summary>
        /// Subtract a specified amount of years from a DateOnly object.
        /// </summary>
        /// <param name="dateOnly">The DateOnly object to be subtracted from.</param>
        /// <param name="years">The amount of years to subtract from the specified DateOnly object.</param>
        /// <returns>the modified DateOnly object.</returns>
        public static DateOnly SubtractYears(this DateOnly dateOnly, int years)
        {
            DateTime result = dateOnly.ToDateTime().SubtractYears(Convert.ToDouble(years));
            return DateOnly.FromDateTime(result);
        }

#endif
        
        
    }
}