using _02_Structs.Structs.Interoperability;
using _02_Structs.Structs.Mathematical_Models;

// Matematiska Modeller
Vector2D vector = new Vector2D(3.0, 4.0);
Console.WriteLine($"Vector: X={vector.X}, Y={vector.Y}");
Console.ReadKey();

// Interoperabilitet
var todo = new Todo { userId = 1, id = 1, title = "delectus aut autem", completed = false };
Console.WriteLine($"Todo: {todo.id} - {todo.title}");
Console.ReadKey();


Console.ReadKey();