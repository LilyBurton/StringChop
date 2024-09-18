namespace StringWithoutVowels;

public class StringChopTest
{
    private StringChop _chop = new StringChop();
    [Theory]
    [InlineData("", "")]
    [InlineData("Hello World", "Hll Wrld")]
    [InlineData("aeiou", "")]
    [InlineData("AEIOU", "")]
    [InlineData("bjclp", "bjclp")]
    [InlineData("Apex Legends", "px Lgnds")]
    public void StringChopVowels(string input, string expected)
    {
       var result = _chop.Chop(input);

       Assert.Equal(expected, result);
    }
}