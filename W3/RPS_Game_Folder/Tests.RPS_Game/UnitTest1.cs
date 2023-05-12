using RpsGame1;

namespace Tests.RPS_Game;


public class UnitTest1
{


    [Fact]
    public void DemoMethodReturnsConcatenatedString1()
    {
        // arrange
        int myint = 23;
        double myDouble = 23.102030;
        string expected = "23 23.10203";

        // act
        string actual = RPS_GamePlay.TestDemoMethod(myint, myDouble);

        //assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(Int32.MaxValue, Double.MaxValue, "2147483647 1.7976931348623157E+308")]
    [InlineData(Int32.MinValue, Double.MinValue, "-2147483648 -1.7976931348623157E+308")]
    [InlineData(Int32.MaxValue, Double.MinValue, "2147483647 -1.7976931348623157E+308")]
    public void DemoMethodReturnsConcatenatedString2(int myint, double myDouble, string expected)
    {
        // arrange
        // done in [Inlinedata]

        // act
        string actual = RPS_GamePlay.TestDemoMethod(myint, myDouble);

        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void RegisterPlayerReturnsCorrectPlayerObj9ect()
    {
        // arrange
        int expected = 111;

        // act
        Person actual = RPS_GamePlay.RegisterPlayer("mark moore dude");

        //assert
        Assert.Equal(expected, actual.age);

    }






}