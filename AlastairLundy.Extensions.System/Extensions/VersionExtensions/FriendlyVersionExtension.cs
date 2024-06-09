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

using AlastairLundy.Extensions.System.VersionExtensions.Enums;
// ReSharper disable RedundantIfElseBlock

namespace AlastairLundy.Extensions.System.VersionExtensions
{
    public static class FriendlyVersionExtension
    {
        /// <summary>
        /// Returns the current version formatted in the specified formatting style.
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public static string ToFriendlyVersionString(this Version version)
        {
            bool showMinor = version.Minor != 0;
            bool showBuild = version.Build != 0;
            bool showRevision = version.Revision != 0;

            switch (showRevision)
            {
                case true:
                    return $"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
                default:
                {
                    if (showBuild)
                    {
                        return $"{version.Major}.{version.Minor}.{version.Build}";
                    }
                    else if(showMinor)
                    {
                        return $"{version.Major}.{version.Minor}";
                    }
                    else
                    {
                        return version.Major.ToString();
                    }
                }
            }
        }
        
        /// <summary>
        /// Returns the current version formatted in the specified formatting style.
        /// </summary>
        /// <param name="version">The current version object.</param>
        /// <param name="friendlyVersionFormatStyle">The version format style to use.</param>
        /// <returns>the current version formatted in the specified formatting style as a string.</returns>
        [Obsolete]
        public static string GetFriendlyVersionToString(this Version version,
            FriendlyVersionFormatStyle friendlyVersionFormatStyle = FriendlyVersionFormatStyle.AutomaticallyRemoveZeros)
        {
            char dot = '.';
            
            bool showMinor = friendlyVersionFormatStyle == FriendlyVersionFormatStyle.MajorDotMinor;
            bool showBuild = friendlyVersionFormatStyle == FriendlyVersionFormatStyle.MajorDotMinorDotBuild;
            bool showRevision = friendlyVersionFormatStyle == FriendlyVersionFormatStyle.MajorDotMinorDotBuildDotRevision;
            
            if (friendlyVersionFormatStyle == FriendlyVersionFormatStyle.AutomaticallyRemoveZeros)
            {
                showMinor = version.Minor != 0;
                showBuild = version.Build != 0;
                showRevision = version.Revision != 0;
            }

            switch (showRevision)
            {
                case true:
                    return $"{version.Major}{dot}{version.Minor}{dot}{version.Build}{dot}{version.Revision}";
                default:
                {
                    if (showBuild)
                    {
                        return $"{version.Major}{dot}{version.Minor}{dot}{version.Build}";
                    }
                    else if(showMinor)
                    {
                        return $"{version.Major}{dot}{version.Minor}";
                    }
                    else
                    {
                        return version.Major.ToString();
                    }
                }
            }
        }
    }
}