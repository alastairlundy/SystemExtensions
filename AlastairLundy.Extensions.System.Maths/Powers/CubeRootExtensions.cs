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

namespace AlastairLundy.Extensions.System.Maths.Powers
{
    public static class CubeRootExtensions
    {
        /// <summary>
        /// Returns the cube root of the decimal.
        /// </summary>
        /// <param name="value">The decimal to be cube rooted.</param>
        /// <returns>the cube root of the decimal.</returns>
        public static decimal CubeRoot(this decimal value)
        {
            return value.Root(3);
        }
        
        /// <summary>
        /// Returns the cube root of the double.
        /// </summary>
        /// <param name="value">The double to be cube rooted.</param>
        /// <returns>the cube root of the double.</returns>
        public static double CubeRoot(this double value)
        {
            return value.Root(3);
        }

        /// <summary>
        /// Returns the cube root of the float.
        /// </summary>
        /// <param name="value">The float to be cube rooted.</param>
        /// <returns>the cube root of the float.</returns>
        public static float CubeRoot(this float value)
        {
            return value.Root(3);
        }
    }
}