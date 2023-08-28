Console.Write("1. Sayı : ");
string? sayi1 = Console.ReadLine();

Console.WriteLine("2. Sayı : ");
string? sayi2 = Console.ReadLine();

var toplam = sayi1 + sayi2;
Console.Write(toplam); // değer dönüşümü yok ise birleştirir, değer dönüşümü var ise toplar
