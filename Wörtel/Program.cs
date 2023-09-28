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
var projectPath = Directory.GetCurrentDirectory();
var csvPath = Path.Combine(projectPath,@"\words\valid_solutions.csv");
var solutionsWordList = GetSolutionsFromFile(csvPath);
{
Random rng = new Random();
var nextSolutionIndex = rng.Next(0, solutionWordList.Count);

var solutionWord = solutionWordList[nextSolutionIndex];
solutionWord = solutionWord.ToUpper();

  while (reader.EndOfStream == false)
  {
    var line = reader.ReadLine();
    solutionWordList.Add(line);
  }
}

string guess;
while (true)
{
  Console.WriteLine("Errate das 5-Stellige Wort");
  guess = Console.ReadLine();
  guess = guess.ToUpper();
  if (guess.Length != 5) continue;

  /*
   Todo:
   - Groß und Kleinschreibung
   - Farbe zurücksetzung nach Ausgabe :Done
   - Foreground color change to blauck; the default color change to white? :Done
   - Ausgabe is dispalyed Horizonally instead of vertically :Done
   - Wenn einmal vorkommende Buchstabe im guess zweimal vorkommt, dark das zweite Vorkommen    nicht Gelb sein
   _ Versuche tählen und User feedback geben ob er das Wort erraten hat oder er alle Versuche verbraten hat
   */
  Console.ForegroundColor = ConsoleColor.Black;
  Console.Beep(200, 1000);
  for (int i = 0; i < guess.Length; i++)
  {
    Console.BackgroundColor = ConsoleColor.White;
    if (solutionWord.Contains(guess[i]))
      Console.BackgroundColor = ConsoleColor.DarkYellow;
    if (solutionWord[i] == guess[i])
      Console.BackgroundColor = ConsoleColor.Green;
    Console.Write($"{guess[i]}");

  }
  Console.BackgroundColor = ConsoleColor.Black;
  Console.ForegroundColor = ConsoleColor.White;
  Console.WriteLine();
}

List<string> GetSolutionsFromFile(string path)
{
  var soulutions = new List<string>();

  using (var reader = new StreamReader(path))
  {
    while (reader.EndOfStream == false)
    {
      var line = reader.ReadLine();
      solutions.Add(line);
    }
  }

  return soulutions;
}