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