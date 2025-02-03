using System;
using System.Linq;
using AlastairLundy.Extensions.System.Strings;
using Bogus;

namespace SystemExtensions.Tests.Strings.EscapeCharacters;

public class EscapeCharacterRemovalTests
{
    [Fact]
    public void ContainsEscapedCharactersTest()
    {
        string text = "Hello World\r\n";

        bool actual = text.ContainsEscapeCharacters();
        
        Assert.True(actual);
    }

    [Fact]
    public void DoesntContainEscapeCharactersTest()
    {
        char[] chars = Chars.UpperCase.ToCharArray();
        Random.Shared.Shuffle(chars);
        
        chars = chars.Take(5).ToArray();
        
        string text = String.Join("", chars);

        bool actual = text.ContainsEscapeCharacters();
        
        Assert.False(actual);
    }
    
    [Fact]
    public void SuccessfullyRemoveEscapeCharsTests()
    {
        string text = "Hello World\r\n";

        string expected = "Hello World";
        
        string actual = text.RemoveEscapeCharacters();
        
        Assert.Equal(expected, actual);
    }
}