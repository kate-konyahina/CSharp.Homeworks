// See https://aka.ms/new-console-template for more information
	
using System.Text;
Console.WriteLine("Введите символьную строку, содержащую хотя бы один символ '?'.");
var str = new StringBuilder(Console.ReadLine());

char[] element = (str.ToString()).ToCharArray();
int indexOper = 0;

for (int i = 0; i < element.Length; i++)
    if (element[i].Equals('?')) { indexOper = i; break; }

var str1 = new StringBuilder(); 
for (int i = 0; i < indexOper; i++)
  str1.Append(element[i]);

 str1.Replace('!', ' ');
 str1.Replace('.', ' ');
var finStr1 = str1.Replace(" ", "");

var str2 = new StringBuilder();
    for (int i = indexOper; i < element.Length; i++)
    str2.Append(element[i]);

str2.Replace(' ', '_');

StringBuilder result = new StringBuilder(string.Concat(finStr1, str2));
Console.WriteLine(result);