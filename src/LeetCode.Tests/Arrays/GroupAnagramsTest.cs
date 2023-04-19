namespace LeetCode.Tests.Arrays;

public class GroupAnagramsTest
{
    [Fact]
    public void GivenArrayOfStrings_ReturnListOfListOfAnagrams()
    {
        var sut = new GroupAnagrams();

        var result = sut.Solve(new[] { "eat", "tea", "tan", "ate", "nat", "bat" });

        Assert.Collection(
            result,
            r => Assert.Collection(
                r,
                s => Assert.Equal("eat", s),
                s => Assert.Equal("tea", s),
                s => Assert.Equal("ate", s)),
            r => Assert.Collection(
                r,
                s => Assert.Equal("tan", s),
                s => Assert.Equal("nat", s)),
            r => Assert.Collection(
                r,
                s => Assert.Equal("bat", s))
            );
    }
    
    [Fact]
    public void GivenEmptyString_ReturnListOfListOfAnagrams()
    {
        var sut = new GroupAnagrams();

        var result = sut.Solve(new[] { "" });

        Assert.Collection(
            result,
            r => Assert.Collection(
                r,
                s => Assert.Equal("", s)));
    }
    
    [Fact]
    public void GivenSingleString_ReturnListOfListOfAnagrams()
    {
        var sut = new GroupAnagrams();

        var result = sut.Solve(new[] { "a" });

        Assert.Collection(
            result,
            r => Assert.Collection(
                r,
                s => Assert.Equal("a", s)));
    }
}