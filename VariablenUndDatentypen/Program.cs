#region Variablen
// Variablen Deklaration
string name;
int age;
object random;
float height;
// Var sind erst nach einer Deklaration verwendbar

// Console.WriteLine(age); --> geht erst nach Init

// var Initialisierung / Assignment
name = "default";
age = 0;
random = new object();
height = 0.0f;

// Dek & Init
int abc = 42;
string hello = "hello"; 
var blubb = Console.ReadLine();

int i = 0;
while(i<5)
{
  var xyz = 10;
  Console.WriteLine(hello);
} // wenn ein Codeblock zugemacht wird sind alle Var die innerhalb des block dek wurden nicht mehr gülti => können nicht verwendet werden-

// xyz
// var xyz = 20; => var kann neue dek werden.

#endregion

#region Primitive-Datentypen
// Primitive-Datentypen => Werte-Typen, Value-Types
bool boolean = false || true;
int ganzzahl = 0;
float width = 1.0f;
double depth = 1.0d;
decimal moneten = 900000000.627m;
var testfloat = 1.0m;
char sign = '+';
char letter = 'B';

#endregion

#region Komplexe-Datentypen
// Komplexe-Typen => Referenz-Typen
object myObject = new object();
string greeting = "Hello World!";
//dynamic myDynamic;
#endregion

#region Wertreferenz-Typen
int num1 = 10;

string mystring = "testme";

var num2 = num1;

var mystring2 = mystring;

num1 = num1 + 1;
mystring = mystring + "mememe";

Console.WriteLine(num1);
Console.WriteLine(mystring);
#endregion