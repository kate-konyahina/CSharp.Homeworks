// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

long[] arr = new long[50_000];
Random num = new Random();
for (long i = 0; i < 50_000; i++) { arr[i] = num.Next(); }

System.Diagnostics.Stopwatch timer = System.Diagnostics.Stopwatch.StartNew();
for (long i = 49_999; i >= 0; i--) { Console.WriteLine(arr[i]); }
timer.Stop();

System.Diagnostics.Stopwatch timer2 = System.Diagnostics.Stopwatch.StartNew();
Array.Reverse(arr);
for(long i = 0; i < 50_000; i++) { Console.WriteLine(arr[i]); }
timer2.Stop();
Console.WriteLine("Time1: {0} ms", timer.ElapsedMilliseconds);
Console.WriteLine("Time2: {0} ms", timer2.ElapsedMilliseconds);