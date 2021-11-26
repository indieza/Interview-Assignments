using Animals;

var dog = new Dog();
var cat = new Cat();

// Generic class with method with generic parameter
var engine1 = new Engine1<Animal>();

engine1.Action(dog);
engine1.Action(cat);
Console.WriteLine("---------------------");

// Generic class with public generic property
var engine2 = new Engine2<Animal>();

engine2.Item = dog;
engine2.Action();
engine2.Item = cat;
engine2.Action();
Console.WriteLine("---------------------");

// Generic Method
var engine3 = new Engine3();

engine3.Action<Animal>(dog);
engine3.Action<Animal>(cat);
Console.WriteLine("---------------------");