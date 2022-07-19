// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Insert adresses: ");
StringBuilder adressesStr = new StringBuilder(Console.ReadLine());
string[] adresses = (adressesStr.ToString()).Split(',');

