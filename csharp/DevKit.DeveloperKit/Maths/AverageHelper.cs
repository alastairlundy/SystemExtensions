using System;
using System.Collections.Generic;
using System.Text;

namespace AluminiumTech.DevKit.DeveloperKit.Maths{
    public class AverageHelper{

        public double ExponentOf(double value, double power)
        {
           return Math.Pow(value, (1.0 / power));
        }

        /// <summary>
        /// Calculate the geometric mean of a given set of numbers.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public double CalculateGeometricMean(double[] values)
        {
            double sum = 1;
            
            for(int index = 0; index < values.Length; index++)
            {
                sum *= values[index];
            }

            return ExponentOf(sum, values.Length);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public double CalculateArithmeticMean(double[] values)
        {
            double sum = 0;

            for (int index = 0; index < values.Length; index++)
            {
                sum += index;
            }

            return sum / values.Length;
        }
    }
}
