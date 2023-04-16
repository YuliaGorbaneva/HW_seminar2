int Random = new Random().Next(100,1000);
Console.WriteLine(Random);

int first = (Random / 10) % 10;

Console.WriteLine($"{first}");