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

namespace AluminiumTech.DevKit.DeveloperKit.StringManipulation
{
    public class ResultsAveraging
    {
        

        public double AverageResults(double[] results)
        {
            double average = 0;

            foreach (var result in results)
            {
                average += result;
            }

            average = average / results.Length;
            return average;
        }
    
        public bool IsAllPositive(bool[] results)
        {
            foreach (var result in results)
            {
                if (result.Equals(false))
                {
                    return false;
                }
                else
                {
                    
                }
            }

            return true;
        }

        public bool IsAllNegative(bool[] results)
        {
            foreach (var result in results)
            {
                if (result.Equals(true))
                {
                    return false;
                }
                else
                {
                    
                }
            }
            return true;
        }
        
        public bool AverageResults(bool[] results)
        {
            int trueCounter = 0;
            int falseCounter = 0;
            
            foreach (bool b in results)
            {
                if (b.Equals(true))
                {
                    trueCounter++;
                }
                else
                {
                    falseCounter++;
                }
            }

            return (trueCounter > falseCounter);
        }

    }
}