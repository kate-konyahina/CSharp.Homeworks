// See https://aka.ms/new-console-template for more information

StreamReader textReader = new StreamReader(@"C:\Users\user\source\repos\kate-konyahina\CSharp.Homeworks\CSharp.Homeworks\HW.04.Image\image.txt", true);
textReader.Dispose();
string textReaderResult = textReader.ReadToEnd();
string arrayOfTextResult = textReaderResult.Split(' ');
byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
{

}
byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
imageBytes[i] = binary;
File.WriteAllBytes(@"C:\Users\user\source\repos\kate-konyahina\CSharp.Homeworks\CSharp.Homeworks\HW.04.Image\image.png", imageBytes);
