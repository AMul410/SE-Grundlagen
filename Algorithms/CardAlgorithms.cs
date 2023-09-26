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

    public static int BinaryFindCardLocation(int[] cards, int query)
    {
      // Setze Variable left auf Wert 0
      int left = 0;
      // Setze Variable right auf Wert Länge von cards minus 1
      int right = cards.Length - 1;

      // Wenn Länge von cards gleich 0
      if (cards.Length == 0)
      {
        //   Wahr: Gebe -1 zurück
        return -1;
      }
      // Schleife solange left kleiner gleich  right:
      while (left <= right)
      {
        //   Setze Variable middle auf den Wert (left + right) / 2
        int middle = (left + right) / 2;
        //   Wenn middle gleich query:
        if (cards[middle] == query)
        {
          //     Wahr: Gebe middle zurück
          return middle;
        }
        //   Wenn query kleiner cards an middle:
        else if (query < cards[middle])
        {
          //     Wahr: Setze right auf den Wert von middle - 1
          right = middle - 1;
        }
        else
        {
          //     Falsch: Setze left auf den Wert von middle + 1
          left = middle + 1;
        }
      }
      return -1;
    }
  }
}
