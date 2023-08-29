int a = 5, b = 5 , c = 10, d = 3;
string username = "denizhan";
string password = "1234";

var sonuc = (a == b);
Console.WriteLine(sonuc);
sonuc = (c == d);

Console.WriteLine(sonuc);

sonuc = (username == "denizhan");
Console.WriteLine(sonuc);

sonuc = (password == "12345");
Console.WriteLine(sonuc);

sonuc = (a != b);
Console.WriteLine(sonuc);

sonuc = (a>b);
Console.WriteLine(sonuc);

sonuc = (a < c);
Console.WriteLine(sonuc);

sonuc = (a >= b);
Console.WriteLine(sonuc);

//tenary
var sonuc2 = (a>b) ? "a buyuk" : "b buyuk";
Console.WriteLine(sonuc2);

sonuc2 = (a>=b) ? "a buyuk" : "b buyuk";
Console.WriteLine(sonuc2);

sonuc2 = (a>b) ? "a buyuk" : (a==b)?"a b eşit" : "b buyuk" ;
Console.WriteLine(sonuc2);