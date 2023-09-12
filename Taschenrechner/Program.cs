Console.WriteLine("Welcome to Calc 3000");
bool checkParse1 = false;
bool checkParse2 = false;
int num1 = 0;
int num2 = 0;

while (!checkParse1 || !checkParse2)
{
  Console.WriteLine("Pls provide the 1st number");
  var input1 = Console.ReadLine();

  Console.WriteLine("Pls provide 2nd number");
  var input2 = Console.ReadLine();


  // Konvertierung von Text zu Zahlen
  checkParse1 = int.TryParse(input1, out num1);
  checkParse2 = int.TryParse(input2, out num2);

}
var result = num1 + num2;
Console.WriteLine($"{num1} + {num2} = {result}");




// "Var ist nicht kombinierbar mit Datentypenangaben
// Entweder (Var) oder Datentyp eg. String, int, float.