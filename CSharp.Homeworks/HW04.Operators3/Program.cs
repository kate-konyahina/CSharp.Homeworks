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

Repeat3:
Console.WriteLine("Чему равна сумма введеннных чисел?");
string inp3 = Console.ReadLine();
bool success3 = int.TryParse(inp3, out int sum);
if (success3 == false)
{
    Console.WriteLine("Введенный символ не является числом.");
    goto Repeat3;
}

if (sum == num1 + num2)
{
    Console.WriteLine("Правильно");
}
else if (sum > num1 + num2)
{
    Console.WriteLine("Неправильно");
    Console.WriteLine("Должно быть меньше");
}
else 
{
    Console.WriteLine("Неправильно");
    Console.WriteLine("Должно быть больше");
}