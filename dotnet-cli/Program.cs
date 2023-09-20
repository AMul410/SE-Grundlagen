Console.WriteLine("Wie viele Zufallzahlen möchtest du?");

var inputAmount = Console.ReadLine();


var randomAmount = int.Parse(inputAmount);

var rng = new Random();

int[] randomNumbers = new int[randomAmount];

for (int i = 0; i < randomNumbers.Length; i++)
{
    randomNumbers[i] = rng.Next(1, 50);
}

Console.WriteLine(string.Join(", ", randomNumbers));