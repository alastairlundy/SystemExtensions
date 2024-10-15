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

using System.IO;

namespace AlastairLundy.Extensions.System.Strings.LineEndings;

public static class GetLineEndingExtensions
{
#if NET6_0_OR_GREATER
    /// <summary>
    /// 
    /// </summary>
    /// <param name="filePath"></param>
    /// <returns></returns>
    public static LineEndingFormat LineEnding(this string filePath)
    {
        LineEndingFormat lineEndingFormat;

        string[] contents = File.ReadAllLines(filePath);

        if (contents[0].EndsWith('\n') && contents[0].Contains('\r') == true)
        {
            lineEndingFormat = LineEndingFormat.LF_CR;
        }
        else if (contents[0].EndsWith('\r') && contents[0].Contains('\n') == true)
        {
            lineEndingFormat = LineEndingFormat.CR_LF;
        }
        else if (contents[0].EndsWith('\n') && contents[0].Contains('\r') == false)
        {
            lineEndingFormat = LineEndingFormat.LF;
        }
        else if (contents[0].EndsWith('\r') && contents[0].Contains('\n') == false)
        {
            lineEndingFormat = LineEndingFormat.CR;
        }
        else
        {
            lineEndingFormat = LineEndingFormat.NotDetected;
        }

        return lineEndingFormat;
    }
#endif
}