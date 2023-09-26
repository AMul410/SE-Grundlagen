namespace GrundlagenOOP;

public class Cat
{
  public string Name;
  public int Age;
  public string Color;

  public Cat(string name, int age, string color) 
  {
    this.Name = name;
    this.Age = age;
    this.Color = color;
  }

  // Konstruktor -> Erstellt eine neue Instanz der Klasse Cat
  // -> Nicht für Static Classes
  public void Miau()
  {
    Console.WriteLine("Miau!");
  }
  public static void Schnurren()
  {
    Console.WriteLine("purrrrrrrr......");
  }
  public override string ToString()
  {
    // $"Text{x}" -> String-Interpolation
    return $"name: {this.Name}\nAge: {this.Age}\nColor: {this.Color}";
  }
}
