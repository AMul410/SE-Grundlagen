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