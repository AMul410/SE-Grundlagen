namespace Algorithms
{
  public static class CardAlgorithms
  {
    public static int FindCardLocation(int[] cards, int query)
    {
      // Initialsiere variable index mit Wert 0
      int index = 0;
      // Schleife bis index gleich länge der cards liste:
      while (index < cards.Length)
      {
        //     Wenn zahl von cards an index gleich query:
        if (cards[index] == query)
        {
          //     wahr: gebe index zurück
          return index;
        }
        //     Inkrement index um 1
        index++;
      }
      return -1;
    }

  }
}
