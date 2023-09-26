Console.WriteLine("Loops-Demo");
int iterCount = 10;

while (iterCount > 0)
{
  Console.WriteLine("WHILE");
  iterCount = iterCount - 1;
  //iterCount--; not --iterCount (Precremente operator)!!!!! Warning!!!!
}

iterCount = 10;
do
{
  Console.WriteLine("DO-WHILE");
  iterCount--;
} while (iterCount > 0);


Console.WriteLine("FOR-LOOP");
for (int i = 0; i < 10; i++)
{
  Console.WriteLine("FOR");
}


List<int> ints = new List<int>() { 1, 2, 3, 42, 100, 200, 23 };

foreach (var x in ints)
{
  Console.WriteLine(x);
}