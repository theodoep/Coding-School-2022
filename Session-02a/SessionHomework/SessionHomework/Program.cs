// 1
Console.WriteLine(1);

String name = "Theodore Papazoglou";
Console.WriteLine("HELLO " + name);

// 2
Console.WriteLine(2);

float a = 5;
float b = 6;
Console.WriteLine(a + b);
Console.WriteLine(a/b);

// 3a
Console.WriteLine("3a");

float c = -1 + 5 * 6;
Console.WriteLine(c);

// 3b
Console.WriteLine ("3b");

float d = 38 + 5 % 7;
Console.WriteLine(d);

// 3c
Console.WriteLine("3c");

float e = 14 + (-3 * 6) / 7;
Console.WriteLine(e);

// 3d
Console.WriteLine("3d");

double f = 2 + (13 / 6) * 6 + Math.Sqrt(7);
Console.WriteLine(f);

// 3e
Console.WriteLine("3e");

double g = (Math.Pow(6,4) + Math.Pow(5,7)) / (9%4);
Console.WriteLine(g);

// 4 
Console.WriteLine(4);

int age = 28;
string gender = "female";
Console.WriteLine ("Your are " + gender + " and you look younger than " + age);

// 5 
Console.WriteLine(5);

double seconds = 8784945412; 
Console.WriteLine(seconds/60);
Console.WriteLine (seconds/3600);
Console.WriteLine((seconds / 3600) / 24);
Console.WriteLine(seconds / (3600 * 24 * 365));

//6
Console.WriteLine(6);
TimeSpan sec = TimeSpan.FromSeconds(seconds);
double mins = sec.TotalMinutes;
double hours = sec.TotalHours;
double days = sec.TotalDays;
double years = days / 365;
Console.WriteLine(mins + " minutes," + hours + " hours," + days + " days," + years + " years");

//7
Console.WriteLine(7);
int tempCel = 27;
int tempKelvin = tempCel + 273;
float tempFahr = tempCel * (9 / 5) + 32;
Console.WriteLine(tempCel + " Celsius is equal to "+ tempKelvin + " Kelvin or " + tempFahr + " Fahrenheit");





