Console.Write("1. Sayı : ");
var sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Sayı : ");
var sayi2 = Convert.ToInt32(Console.ReadLine());

var toplam = sayi1 + sayi2;
Console.Write(toplam); // değer dönüşümü yok ise birleştirir, değer dönüşümü var ise toplar


//büyük bir veriyi küçük veriye aktar
//bilinçli veri dönüşümü
//hata
// int a = 10;
// byte b = a;
// long a = 20;
// int b = a;

//küçük veri büyük veriye aktar
int a = 10;
long b = a;

//bilinçli tür dönüşümü
long d = 20;
int e = (int)d;

//veri kaybı oluşabilir
double f = 20.5;
float g = (float)f;

double h = 10.5;
int i = (int)h;
Console.WriteLine(i);

int x = 10;
string z = x.ToString();