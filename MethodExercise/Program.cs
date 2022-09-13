// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello - what is your first name?");
var userName = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"Hi {userName}, What is your favorite color?");
var color = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"{color} is my favorite too! What is your favorite animal?");
var animal = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"{animal} are cool! What is your favorite band?");
var band = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"{band} makes awesome music!");
Console.WriteLine();
Console.WriteLine($"Thank you {userName}, here is your profile.");
Console.WriteLine("-----------------------------");
Console.WriteLine($"name: {userName}");
Console.WriteLine($"favorite color: {color}");
Console.WriteLine($"favorite animal: {animal}");
Console.WriteLine($"favorite band: {band}");


