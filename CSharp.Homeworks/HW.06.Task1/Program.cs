// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Вставьте отрывок любого русского стихотворения в одну строку, используя \';\' для разделения строчек.");
string poem = Console.ReadLine();
string poem2 = poem.Replace('о', 'а');
string[] lines = poem2.Split(';');
foreach (string line in lines) { Console.WriteLine(line); }