// See https://aka.ms/new-console-template for more information

Console.WriteLine("Найте корни уравнения ax^2 + bx + c = 0");

Console.WriteLine("Ввeдите значение аргументa a и нажмите Enter");
 string inp1 = Console.ReadLine();
 int a = Int32.Parse(inp1);

Console.WriteLine("Ввeдите значение аргументa b и нажмите Enter");
string inp2 = Console.ReadLine();
int b = Int32.Parse(inp2);

Console.WriteLine("Ввeдите значение аргументa c и нажмите Enter");
string inp3 = Console.ReadLine();
int c = Int32.Parse(inp3);

//найдем дискриминант уравнения
int discr = b * b - 4 * a * c;

//проверка на наличие корней
if (discr >= 0)
{
    double x1 = (-b + Math.Sqrt(discr)) / (2 * a);
    double x2 = (-b - Math.Sqrt(discr)) / (2 * a);

    Console.WriteLine("x1 = " + x1);
    Console.WriteLine("x2 = " + x2);
}
else
    Console.WriteLine("Уравнение не имеет корней.");

