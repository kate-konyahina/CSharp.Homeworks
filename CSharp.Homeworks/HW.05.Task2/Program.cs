// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] arr1 = new int[10];
Console.WriteLine("Введите значения массива");
for (int i = 0; i < 8; i++) { arr1[i]= int.Parse(Console.ReadLine()); }
Console.WriteLine("Исходный массив:");
for (int i = 0; i < 9; i++) { Console.Write(arr1[i] + " "); }

Console.WriteLine();
Console.WriteLine("Введите дополнительный элемент массива");
int elem = int.Parse(Console.ReadLine());

Console.WriteLine("Введите номер позиции для вставки элемента (отсчет идет от 0)");
int pos = int.Parse(Console.ReadLine());

int[] arr2 = new int[10];
for (int i = 0; i < 9; i++)
{
    if (i == pos) { arr2[i] = elem; }
    else if ( i < pos ) { arr2[i] = arr1[i]; }
    else { arr2[i] = arr1[i-1]; }
}
for (int i = 0; i < 9; i++) { Console.Write(arr2[i] + " "); }