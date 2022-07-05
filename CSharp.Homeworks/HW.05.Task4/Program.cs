// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Введите положительное число");
int num = int.Parse(Console.ReadLine());
int[] arr1 = new int[num];
int sum = 0;
for (int i = 0; i < num; i++) { arr1[i] = i + 1; }
for (int i = 0; i < num; i++) { Console.WriteLine(arr1[i]); }
for (int i = 0; i < num; i++) { sum += arr1[i]; }
Console.WriteLine("Сумма элементов равна: " + sum);
