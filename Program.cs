int a;
Console.Write($"Введите число ");
int.TryParse(Console.ReadLine()!, out a);

Console.WriteLine($"{a}^2 = {a * a}");
Console.WriteLine($"{a}^2 = {a * a * a}");
Console.WriteLine($"{a}^2 = {a * a * a * a}");
Console.WriteLine($"{a}^2 = {a * a * a * a * a}");


