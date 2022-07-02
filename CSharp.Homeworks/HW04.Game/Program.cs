// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

char key = char.ToLower(Console.ReadKey(true).KeyChar);
switch (key)
{
    case (char)97:
        Console.WriteLine("Движение влево");
        break;

    case (char)119:
        Console.WriteLine("Движение вверх");
        break;

    case (char)115:
        Console.WriteLine("Движение вниз");
        break;

    case (char)100:
        Console.WriteLine("Движение вправо");
        break;

        default:
        Console.WriteLine("Необходимость перемещения отсутствует");
        break;
}

