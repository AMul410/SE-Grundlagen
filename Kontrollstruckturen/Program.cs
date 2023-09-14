Console.WriteLine("bitte deine Alte angeben");
var inputAge = Console.ReadLine();

var age = int.Parse(inputAge);

if (age < 16) // Bedingung ist einfach ein ausgedruck, der True oder False ergibt.
{
  Console.WriteLine("NEIN");
} 
else if (age >= 16 && age < 18) // Beliebig viele else-if Anweisungen pro if-Anweisung möglich
{
  Console.WriteLine("Vielleicht");
}
else // Aber immer nur 1 else pro if-Anweisung
{
  Console.WriteLine("Willkommen");
}

Console.WriteLine("Done!");
/*
if (age < 18) {

} else {

}

while (true) {

}
*/

Console.WriteLine("which day of the week 1 Mon - 5 Frei");
var inputWeekday = Console.ReadLine();

var weekday = int.Parse(inputWeekday);

switch (weekday)
{
  case 1:
    Console.WriteLine("Montag");
    break;
  case 2:
    Console.WriteLine("Dienstag");
    break;
  case 3:
    Console.WriteLine("Mittwoch");
    break;
  case 4:
    Console.WriteLine("Donnerstag");
    break;
  case 5:
    Console.WriteLine("Freitag");
    break;      
  default:
    Console.WriteLine("Zahl ist kein Wochentag");
    break;
}
