// See https://aka.ms/new-console-template for more information


// a. 10 examples of explicit type conversion

int num1 = -10;
int num2 = 20;
byte res1 = (byte) (num1 + num2);
Console.WriteLine(res1);

short num3 = 26;
short num4 = 50;
sbyte res2 = (sbyte) (num3 + num4);
Console.WriteLine(res2);

long num5 = 56_729_804_040;
long num6 = 56_729_804_036;
ushort res3 = (ushort) (num5 - num6);
Console.WriteLine(res3);

int num7 = 100;
int num8 = 25;
short num9 = 5;
sbyte res4 = (sbyte) ((num7 + num8) / num9);
Console.WriteLine(res4);

double num10 = Math.Pow(3, 201);
double num11 = Math.Pow(3, 200);
int res5 = (int) (num10 / num11);
Console.WriteLine(res5);

decimal num12 = 456_500_500_500_500_500;
long num13 = 500_500_500_500_500;
float res6 = (float) (num12 / num13);
Console.WriteLine(res6);

double num14 = 54.57585857;
double num15 = 32.53585856;
float res7 = (float) (num14 - num15);
Console.WriteLine(res7);

double num16 = 567 * Math.PI;
int res8 = (int) (num16 / 16);
Console.WriteLine(res8);

float res9 = (float) Math.Log10(36789);
Console.WriteLine(res9);

uint num17 = 4_567;
ushort num18 = 4_325;
byte res10 = (byte)(num17 - num18);
Console.WriteLine(res10);

// b. 10 examples of implicit type conversion

int num19 = -10;
int num20 = 20;
decimal res11 = num19 + num20;
Console.WriteLine(res11);

sbyte num21 = 26;
sbyte num22 = 50;
int res12 = num21 * num22 *100;
Console.WriteLine(res12);

byte num23 = 10;
short res13 = num23;
Console.WriteLine(res13);

byte num24 = 15;
short num25 = 125;
int num26 = 563;
long res14 = num24 * num25 * num26;
Console.WriteLine(res14);

float num27 = 3.4f;
double res15 = num27 * 0.12345678;
Console.WriteLine(num15);

int num28 = 1065;
double res16 = Math.Sqrt(num28);
Console.WriteLine(res16);

long num29 = 29_234_234_567;
long num30 = 34_567_562_984;
decimal res17 = num29 * num30;
Console.WriteLine(res17);

uint num31 = 45_567;
ushort num32 = 325;
double res18 = Math.Max(num31, num32);
Console.WriteLine(res18);

sbyte num33 = 10;
long res19 = num33 * 10_198_198_123;
Console.WriteLine(res19);

float num34 = 16.26f;
double res20 = Math.Round(num34);
Console.WriteLine(res20);

// c. 10 boxing examples

int num35 = 345;
object res21 = num35;
Console.WriteLine(res21);

float num36 = 56.5f;
object res22 = num36 + 20;
Console.WriteLine(res22);

int num37 = 456;
float num38 = 67.5f;
object res23 = num37 / num38;
Console.WriteLine(res23);

bool isMale = false;
object ob1 = isMale;
string name = "Maria";
string res24 = "The statement - " + name + " is a man. - is " + ob1;
Console.WriteLine(res24);

ulong num39 = 57_567_987_456;
object res25 = Math.Sqrt(num39);
Console.WriteLine(res25);

decimal num40 = 587_287_456_3765_567_456;
object res26 = num40;
Console.WriteLine(res26);

char char1 = 'X';
object res27 = char1;
Console.WriteLine(res27);

uint num41 = 256_723;
uint num42 = 89_345;
object res28 = num41 / num42;
Console.WriteLine(res28);

float num43 = num41;
float num44 = num42;
object res29 = num43 / num44;
Console.WriteLine(res29);

object res30 = num43 % num44;
Console.WriteLine(res30);

// d. 10 unboxing examples

object obj2 = 123;
int res31 = (int) obj2;
Console.WriteLine(res31);

object obj3 = true;
bool res32 = (bool)obj3;
Console.WriteLine(res32);

object obj4 = Math.Sqrt(35678);
double res33 = (double)obj4;
Console.WriteLine(res33);

object obj5 = 456.789f;
float res34 = (float)obj5;
res34 += 20.67f;
Console.WriteLine(res34);

object obj6 = 'V';
char res35 = (char)obj6;
Console.WriteLine(res35);

object obj7 = 3;
object obj8 = 4;
object obj9 = 5;
int res36 = (int)obj7 + (int)obj8 + (int)obj9;
Console.WriteLine(res36);

object obj10 = Math.Max(35678, 5678);
int res37 = (int)obj10;
Console.WriteLine(res37);

object obj11 = Math.Pow(345.5, 3);
double res38 = (double)obj11;
Console.WriteLine(res38);

object obj12 = Math.Pow(Math.Min(2, 3), 4);
double res39 = (double)obj12;
Console.WriteLine(res39);

object obj13 = 567_567_789_456_456;
long res40 = (long)obj13;
Console.WriteLine(res40);