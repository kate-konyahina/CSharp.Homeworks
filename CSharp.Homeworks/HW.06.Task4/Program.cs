// See https://aka.ms/new-console-template for more information
using System.Globalization;
Console.OutputEncoding = System.Text.Encoding.UTF8;
int val = 1;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("be-BY");
string messageBy = "Date and time format for Belarus is {0}. The national currency is {1}.";
string formatBy = string.Format(messageBy, DateTime.Now, $"{val:c}");
Console.WriteLine(formatBy);
Console.WriteLine($"\nDate and time format for Belarus is {DateTime.Now}. The national currency is {val:c}.");

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pl-PL");
string messagePl = "\nDate and time format for Poland is {0}. The national currency is {1}.";
string formatPl = string.Format(messagePl, DateTime.Now, $"{val:c}");
Console.WriteLine(formatPl);
Console.WriteLine($"\nDate and time format for Poland is {DateTime.Now}. The national currency is {val:c}.");

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-GB");
string messageGb = "\nDate and time format for United Kingdom is {0}. The national currency is {1}.";
string formatGb = string.Format(messageGb, DateTime.Now, $"{val:c}");
Console.WriteLine(formatGb);
Console.WriteLine($"\nDate and time format for United Kingdom is {DateTime.Now}. The national currency is {val:c}.");

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("nl-NL");
string messageNl = "\nDate and time format for the Netherlands is {0}. The national currency is {1}.";
string formatNl = string.Format(messageNl, DateTime.Now, $"{val:c}");
Console.WriteLine(formatNl);
Console.WriteLine($"\nDate and time format for the Netherlands is {DateTime.Now}. The national currency is {val:c}.");

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("it-IT");
string messageIt = "\nDate and time format for Italy is {0}. The national currency is {1}.";
string formatIt = string.Format(messageIt, DateTime.Now, $"{val:c}");
Console.WriteLine(formatIt);
Console.WriteLine($"\nDate and time format for Italy is {DateTime.Now}. The national currency is {val:c}.");

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("fr-FR");
string messageFr = "\nDate and time format for France is {0}. The national currency is {1}.";
string formatFr = string.Format(messageFr, DateTime.Now, $"{val:c}");
Console.WriteLine(formatFr);
Console.WriteLine($"\nDate and time format for France is {DateTime.Now}. The national currency is {val:c}.");

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("fr-CA");
string messageCa = "\nDate and time format for Canada is {0}. The national currency is {1}.";
string formatCa = string.Format(messageCa, DateTime.Now, $"{val:c}");
Console.WriteLine(formatCa);
Console.WriteLine($"\nDate and time format for Canada is {DateTime.Now}. The national currency is {val:c}.");

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
string messageUs = "\nDate and time format for USA is {0}. The national currency is {1}.";
string formatUs = string.Format(messageUs, DateTime.Now, $"{val:c}");
Console.WriteLine(formatUs);
Console.WriteLine($"\nDate and time format for USA is {DateTime.Now}. The national currency is {val:c}.");