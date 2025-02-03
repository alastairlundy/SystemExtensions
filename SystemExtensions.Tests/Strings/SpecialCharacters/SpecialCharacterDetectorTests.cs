
using AlastairLundy.Extensions.System.Strings;
using Bogus;

namespace SystemExtensions.Tests.Strings.SpecialCharacters;

public class SpecialCharacterDetectorTests
{
    public static char[] lowerCaseChars = Chars.LowerCase.ToCharArray();
    
    [Theory]
    public void NotASpecialCharacter(char character)
    {
        bool actual = character.IsSpecialCharacter();
        
        Assert.False(actual);
    }

    public void IsASpecialCharacter()
    {
        
    }
}