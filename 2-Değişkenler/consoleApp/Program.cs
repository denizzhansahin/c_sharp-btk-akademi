var kdvOrani = 1.18; //değişken oluşturma
var urunA = 5000;
var urunB = 6000;
var urunC = 7000;
var urunD = 5000;

Console.WriteLine("Eski Alan");
Console.WriteLine(5000 * 1.18); //urunA
Console.WriteLine(6000 * 1.18); //urunB
Console.WriteLine(7000 * kdvOrani); //urunC
Console.WriteLine(5000 * kdvOrani); //urunD

Console.WriteLine("Yeni Alan");
Console.WriteLine(urunA * kdvOrani); //urunA
Console.WriteLine(urunB * kdvOrani); //urunB
Console.WriteLine(urunC * kdvOrani); //urunC
Console.WriteLine(urunD * kdvOrani); //urunD