// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Implicit Conversion (Bilinçsiz Dönüşüm) : Düşük kapasiteli bir değişkenin kendinden daha yükse kapasiteli başka bir değişkene atanma işlemidir. Bu çeviriyi makina kullanıcı yerine yapıyor.

Console.WriteLine("******** Implicit Conversion **********");

byte a = 5;
sbyte b = 30;
short c = 10;

int d = a + b + c;
Console.WriteLine("d : " + d);

long h = d;
Console.WriteLine("h : " + h);

float i = h;
Console.WriteLine("i : " + h);

string e = "Furkan ";
char f = 'k';
object g = e + f + d;
Console.WriteLine("g : " + g);

// Explicit Conversion (Bilinçli Dönüşüm) : C#'ın kendi kendine yapamadığı dönüşümler. Derleyiciye sizin belirtmeniz lazım.

Console.WriteLine("******* Explicit Conversion **********");

int x = 4;
byte y = (byte)x;
Console.WriteLine("y : " + y);

int z = 100;
byte t = (byte)z;
Console.WriteLine("t : " + t);

float w = 10.3f;
byte v = (byte)w;
Console.WriteLine("v : " + v);






Console.ReadLine();