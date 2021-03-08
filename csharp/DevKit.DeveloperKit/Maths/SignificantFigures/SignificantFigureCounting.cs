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

using System.Collections.Generic;

namespace AluminiumTech.DevKit.DeveloperKit.Maths.SignificantFigures
{
    public class SignificantFigureCounting
    {
        public SignificantFigure[] CountSignificantFigures(string source)
        {
            List<SignificantFigure> significantFigures = new List<SignificantFigure>();
            
            bool reachedPeriod = false;
            
            for (int index = 0; index < source.Length; index++)
            {
                var current = source[index];

                if (current.Equals('.') && !reachedPeriod)
                {
                    reachedPeriod = true;

                    if(int.Parse(current.ToString()) > 0 && int.Parse(current.ToString()) <= 9)
                    {
                        var sf = new SignificantFigure(index, int.Parse(current.ToString()),source);
                        significantFigures.Add(sf);
                    }
                }
                else if(reachedPeriod)
                {
                    if(int.Parse(current.ToString()) >= 0 && int.Parse(current.ToString()) <= 9)
                    {
                        var sf = new SignificantFigure(index, int.Parse(current.ToString()),source);
                        significantFigures.Add(sf);
                    }
                }
            }

            return significantFigures.ToArray();
        }

        public int CountNumberOfSignificantFigures(string source)
        {
            return CountSignificantFigures(source).Length;
        }
    }
}