namespace GrundlagenOOP;

internal class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello, World!"); // Statische-Klasse
    Random rng = new Random(); // Instanzierbare-Klasse
    // Cat myCat = new Cat();
    int x;
    Cat y; // Cat is our own type
    // myCat.Miau();
    // myCat.Name = "Vanessa";
    // myCat.Age = 10;
    // myCat.Color = "Silver-Tabby";
    // Cat myCat2 = new Cat();
    // myCat2.Color = "Brown";
    // myCat2.Name = "Kaja";
    // myCat2.Age = 5;
    // Console.WriteLine(myCat);
    // Console.WriteLine(myCat2);
    // myCat2.Name = "JK";
    // Console.WriteLine(myCat2);

    Cat jerry = new Cat("jerry", 8, "Black");
    Console.WriteLine(jerry);
    jerry.Age += 1;

    Console.WriteLine(jerry);
    
    jerry.Miau();
    Cat.Schnurren();
    

    Console.ReadLine();

    // fields vs properties
    Dog myDog = new Dog(0, "fifi", "white", 3);
    var myDog2 = new Dog(1, "susi", "black", 5);
    Dog myDog3 = new(2, "maria", "golden", 10);
    myDog.Wuff();

    myDog.name = "fritz";
    myDog.Id = 1;
    Console.WriteLine(myDog.Id);

   }
}