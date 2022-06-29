// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите год своего рождения");
string inp1 = Console.ReadLine();
int yYear = Int32.Parse(inp1);

Console.WriteLine("Введите номер месяца своего рождения");
string inp2 = Console.ReadLine();
int yMonth = Int32.Parse(inp2);

int yAge = DateTime.Now.Year - yYear;
if (DateTime.Now.Month < yMonth)
{
    Console.WriteLine("Ваш возраст: " + (yAge - 1));
}
else
Console.WriteLine("Ваш возраст: " + yAge);
