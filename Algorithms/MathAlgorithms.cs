using System.Runtime.InteropServices;

namespace Algorithms;

public static class MathAlgorithms
{
  public static int Factorial(int n)
  {
    var i = n;
    while (i > 1)
    {
      i--;
      n = n * i;
    }
    return n;
  }
  public static int FactorialFor(int n)
  {
    int sum = n;

    for (int i = 1; i < n; i++)
    {
      sum = sum * i;
    }
    return sum;
  }
}

