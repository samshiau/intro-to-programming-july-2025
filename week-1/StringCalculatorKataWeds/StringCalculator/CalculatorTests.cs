

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("0")]
    [InlineData("1")]
    [InlineData("2")]
    public void ReturnWithSingle(string mystring) {
        var calculator = new Calculator();
        int result=calculator.Add(mystring);

        Assert.Equal(int.Parse(mystring), result);

    
    }

    [Theory]
    [InlineData("0,3")]
    [InlineData("2,3")]
    public void ReturnWithTwoNums(string mystring) { 
        var calculator =new Calculator();
        int result=calculator.Add(mystring);

        int ans = int.Parse(mystring[0].ToString()) + int.Parse(mystring[2].ToString());

        Assert.Equal((int)ans, result);
    }


    [Theory]
    [InlineData("1,2,3,4")]
    [InlineData("1,2,3")]
    [InlineData("3,4,5,6,6,5,6,7,7")]
    public void ReturnWithRandomLength(string mystr) { 
        var calculator =new Calculator();
        int result=calculator.Add(mystr);

        int ans = 0;
        for (int i = 0; i < mystr.Length; i++) {
            if (i % 2 == 0)
            {
                ans += int.Parse(mystr[i].ToString());
            }

        }


        Assert.Equal(ans, result);
    
    }


    [Theory]
    [InlineData("1\n2,3")]
    [InlineData("1\n2,3,4,3\n8")]
    public void ReturnWithMixedDelimeters(string str) { 
        var calculator =new Calculator();
        int result=calculator.Add(str);

        int ans = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsDigit(str[i]))
            {
                ans += int.Parse(str[i].ToString());
            }

        }
        Assert.Equal(ans, result);
    }

    [Theory]
    [InlineData("1\n2,&^%3")]
    [InlineData("1\n2,))(3,//*4,3\n8")]
    public void ReturnWithRandDelimeters(string str)
    {
        var calculator = new Calculator();
        int result = calculator.Add(str);

        int ans = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsDigit(str[i]))
            {
                ans += int.Parse(str[i].ToString());
            }

        }
        Assert.Equal(ans, result);
    }

  //  [Theory]
  //  [InlineData("-1,2,-3*(&(-4")]
  //  public void ReturnErrWhileNegativeStr(string str) { 
    //    var calculator =new Calculator();
    //    int result = calculator.Add(str);

    //    Assert.Equal("Invalid input",result.Message);
    
    
 //   }


}
