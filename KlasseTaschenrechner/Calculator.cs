namespace KlasseTaschenrechner
{
  internal class Calculator
  {
    public static int Add(int number1, int number2)
    {
      return number1 + number2;
    }

    public static int Subtract(int number1, int number2)
    {
      return number1 - number2;
    }
    public int Factorial(int n)
    {
      var i = n;
      while (i > 1)
      
      i--;
      n = n * i;
      return n;
      
    }
   }
 }