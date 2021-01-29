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

namespace AluminiumTech.DevKit.DeveloperKit.Maths.SignificantFigures
{
    public struct SignificantFigure
    {
        public int PositionWithinSource { get; set; }

        public int Value { get; set; }
        
        public string Source { get; set; }
        
        
        public SignificantFigure(int PositionWithinSource, int Value, string Source)
        {
            this.PositionWithinSource = PositionWithinSource;
            this.Source = Source;
            this.Value = Value;
        }
    }
}