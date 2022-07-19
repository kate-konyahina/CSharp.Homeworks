// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<char> num1 = new List<char>();
List<char> num2 = new List<char>();

Console.WriteLine("Insert a string with letters, numbers and jne operator(+, -, *, /).");

string text = Console.ReadLine();
char[] element = text.ToCharArray();
int indexOper = 0;

for (int i = 0; i < element.Length; i++)
    if (element[i] == '-') indexOper = i;
    else if (element[i] == '+') indexOper = i;
    else if (element[i] == '*') indexOper = i;
    else if (element[i] == '/') indexOper = i;
    
for (int i = 0; i < indexOper; i++)
   if (char.IsNumber(element[i])) num1.Add(element[i]);
    
for (int i = indexOper; i < element.Length; i++)
   if (char.IsNumber(element[i]))  num2.Add(element[i]);

string num1Str = new string(num1.ToArray());
int.TryParse(num1Str, out int number1);

string num2Str = new string(num2.ToArray());
int.TryParse(num2Str, out int number2);

int result = 0;
for (int i = 0; i < element.Length; i++)
    if (element[i] == '-') result = number1 - number2;
    else if (element[i] == '+') result = number1 + number2;
    else if (element[i] == '*') result = number1 * number2;
    else if (element[i] == '/') result = number1 / number2;

Console.WriteLine(result);
