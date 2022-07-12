/* BSD 3-Clause License
    
    Copyright (c) 2020-2021, AluminiumTech DevKit
    All rights reserved.
    
    Redistribution and use in source and binary forms, with or without
    modification, are permitted provided that the following conditions are met:
    
    1. Redistributions of source code must retain the above copyright notice, this
       list of conditions and the following disclaimer.
    
    2. Redistributions in binary form must reproduce the above copyright notice,
       this list of conditions and the following disclaimer in the documentation
       and/or other materials provided with the distribution.
    
    3. Neither the name of the copyright holder nor the names of its
       contributors may be used to endorse or promote products derived from
       this software without specific prior written permission.
    
    THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
    AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
    IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
    DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
    FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
    DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
    SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
    CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
    OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
    OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
    */

using System;
using System.Globalization;

namespace AluminiumTech.DeveloperKit.Maths.SignificantFigures
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