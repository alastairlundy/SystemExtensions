/*
        MIT License
       
       Copyright (c) 2025 Alastair Lundy
       
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

using AlastairLundy.Extensions.System.Strings;

using Bogus.DataSets;

using Xunit.Abstractions;

namespace SystemExtensions.Tests.Strings.Contains;

public class ContainsSpacesTests
{
    private readonly ITestOutputHelper _testOutputHelper;
    private readonly Lorem _lorem = new();

    public ContainsSpacesTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void UnspacedWordDetection()
    {
        string text = _lorem.Word().Replace(" ", string.Empty).Replace(' ', 'a');

        _testOutputHelper.WriteLine($"Text: {text}");
        _testOutputHelper.WriteLine($"Text2: {text.Split(' ').ToString()}");

        bool actual = text.ContainsSpaceSeparatedSubStrings();
        
        Assert.False(actual);
    }
    
    [Fact]
    public void SpacedWordsDetection()
    {
        string text = string.Join(' ', _lorem.Words(Random.Shared.Next(2, 4)));
        
        bool actual = text.ContainsSpaceSeparatedSubStrings();
        
        Assert.True(actual);
    }

    [Fact]
    public void WordWithEmptyStringDetection()
    {
        string text = _lorem.Word() + " ";
        
        bool actual = text.ContainsSpaceSeparatedSubStrings();
        
        Assert.True(actual);
    }
}