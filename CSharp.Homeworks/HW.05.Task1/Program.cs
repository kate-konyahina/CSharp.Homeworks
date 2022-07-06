// See https://aka.ms/new-console-template for more information

int[] arr1 = new int[5] ;
Random rnd = new Random();
for (int i = 0; i < 5; i++) { arr1[i] = rnd.Next(1, 50); }
Console.WriteLine("Array1: ");
for(int i = 0; i < 5; i++) { Console.Write(arr1[i] + " "); }

Console.WriteLine();
Console.WriteLine("Введите значение для второго массива (от 0 до 50)");
int[] arr2 = new int[5] ;
for (int i = 0; i < 5; i++) { arr2[i] = int.Parse(Console.ReadLine()); }
Console.WriteLine("Array2: ");
for (int i = 0; i < 5; i++) { Console.Write(arr2[i] + " "); }

int[] arr3 = new int[5];
for (int i = 0; i < 5; i++) { arr3[i] = arr1 [i] + arr2[i]; }
Console.WriteLine();
Console.WriteLine("Array3: ");
for (int i = 0; i < 5; i++) { Console.Write(arr3[i] + " "); }
