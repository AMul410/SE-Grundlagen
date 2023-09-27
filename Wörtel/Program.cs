/*
 * Programmstart: 
 * 
 * Definiere solutionWord als das zu erratende Wort fest
 * 
 * Schleife:
 *    Definiere guess und speicher das vom User eingegebene Wort
 *    Schleife für jeden Buchstaben in guess:
 *        Schleife für jeden Buchstaben im solutionWord:
 *            Prüfe Buchstabe aus guess gleich Buchstabe in solutionWord:
 *                Wahr:
 *                
 */

var solutionWord = "HOTEL";

string guess;

while (true)
{
  Console.WriteLine("Errate das 5-Stellige Wort");
  guess = Console.ReadLine();
  if (guess.Length != 5) continue;

  // foreach (char c in guess)
  // {
  //  if (solutionWord.Contains(c));
  //    Console.BackgroundColor = ConsoleColor.Yellow;
  //  if (/* ... */)
  //    Console.BackgroundColor = ConsoleColor.Green;
  //    Console.WriteLine($"{c}");
  // }



  // Gedankenspiel

  for(int i = 0; i < guess.Length; i++)
  {
    if (solutionWord.Contains(guess[i]))
      Console.BackgroundColor = ConsoleColor.Yellow;
    if (solutionWord[i] == guess[i])
      Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine($"{guess[i]}");
  }

  // int i = 0;
  // while (i < guess.Length)
  // {
  //   var c = guess[i];
  //   // dein code ..
  //  i ++;
  // }
}
