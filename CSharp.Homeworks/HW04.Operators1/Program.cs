// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

 Repeat1:
 Console.WriteLine("Введите первое слагаемое:");
 string inp1 = Console.ReadLine();
 bool success1 = int.TryParse(inp1, out int num1);
 if (success1 == false)
 {
    Console.WriteLine("Введенный символ не является числом.");
    goto Repeat1;
 }

Repeat2:
Console.WriteLine("Введите второе слагаемое:");
string inp2 = Console.ReadLine();
bool success2 = int.TryParse(inp2, out int num2);
if (success2 == false)
{
    Console.WriteLine("Введенный символ не является числом.");
    goto Repeat2;
}

Console.WriteLine("Сумма введенных чисел равна - " + (num1 + num2));