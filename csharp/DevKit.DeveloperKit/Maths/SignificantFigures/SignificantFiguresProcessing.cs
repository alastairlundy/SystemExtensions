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

using System;

using System.Collections.Generic;

using System.Globalization;

namespace AluminiumTech.DevKit.DeveloperKit.Maths.SignificantFigures
{
    public class SignificantFiguresProcessing
    {
        protected SignificantFigureCounting _significantFigureCounting;

        public SignificantFiguresProcessing()
        {
            _significantFigureCounting = new SignificantFigureCounting();
        }

        public string ReturnToNSignificantFiguresLossy(int source, int numberOfSignificantFigures)
        {
            return ReturnToNSignificantFiguresLossy(Convert.ToDecimal(source), numberOfSignificantFigures);
        }
        
        public string ReturnToNSignificantFiguresLossy(long source, int numberOfSignificantFigures)
        {
            return ReturnToNSignificantFiguresLossy(Convert.ToDecimal(source), numberOfSignificantFigures);
        }
        
        public string ReturnToNSignificantFiguresLossy(double source, int numberOfSignificantFigures)
        {
            return ReturnToNSignificantFiguresLossy(Convert.ToDecimal(source), numberOfSignificantFigures);
        }
        
        public string ReturnToNSignificantFiguresLossy(decimal source, int numberOfSignificantFigures)
        {
            try
            {
                return source.ToString("G" + numberOfSignificantFigures.ToString(), CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }
        
        /// <summary>
        /// Insert or remove Significant Figures as needed. 
        /// WARNING: This is an experimental feature. Use at your own peril.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="numberOfSignificantFigures"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string ExperimentalReturnToNSignificantFigures(string source, int numberOfSignificantFigures)
        {
            try
            { 
                var currentSF = _significantFigureCounting.CountNumberOfSignificantFigures(source);

                var sfs = _significantFigureCounting.CountSignificantFigures(source);
            
            if (currentSF < numberOfSignificantFigures)
            {
                int next = 0;

                for (int index = 0; index < numberOfSignificantFigures; index++)
                {
                    int current = sfs[index].Value;

                    if (sfs.Length >= index + 1)
                    {
                        next = sfs[index + 1].Value;
                    }

                    if (next.Equals(0))
                    {
                        
                    }
                }

                return next.ToString();
            }
            else if(currentSF > numberOfSignificantFigures)
            {
                int lastNonZeroSF = 0;
                int secondLastNonZeroSF = 0;
            
                while (currentSF > numberOfSignificantFigures)
                {

                    for (int reverseIndex = sfs.Length; reverseIndex > 3; reverseIndex--)
                    {
                        int value = sfs[reverseIndex].Value;
                        int secondLastValue = sfs[reverseIndex - 1].Value;

                        if (value != 0)
                        {
                            lastNonZeroSF = value;
                        }
                        if (secondLastValue != 0)
                        {
                            secondLastNonZeroSF = value;
                        }

                        if (value != 0 && secondLastValue != 0)
                        {
                            if (lastNonZeroSF >= 5)
                            {
                                if (secondLastNonZeroSF < 9)
                                {
                                    sfs[reverseIndex - 1].Value++;
                                    sfs[reverseIndex].Value = 0;
                                }
                                else
                                {
                                    if (sfs[reverseIndex - 2].Value < 9)
                                    {
                                        sfs[reverseIndex - 2].Value++;
                                        sfs[reverseIndex - 1].Value = 0;
                                        sfs[reverseIndex].Value = 0;
                                    }
                                }
                            }
                        }
                        
                    }
                    
                    numberOfSignificantFigures++;
                }
            }
                // if (currentSF == numberOfSignificantFigures)
                return source;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }
        
    }
}