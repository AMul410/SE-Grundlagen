using KlasseTaschenrechner;

namespace TestAlgorithms
{
  public class CalculatorTest
  {
    [Fact]
    public void TestCheckNumberIsPrime()
    {
      var number = 5;
      Assert.Equal(true, Calculator.CheckNUmberIsPrime(number));    
    }
    [Fact]
    public void TestCheckNumberIsNotPrime()
    {
      var number = 6;
      Assert.Equal(false, Calculator.CheckNUmberIsPrime(number));
    }
  }
}
