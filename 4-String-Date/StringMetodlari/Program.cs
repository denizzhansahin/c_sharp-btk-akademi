string mesaj = " Denizhan isimli kişi 20 yaşındadır. ";
Console.WriteLine(mesaj);
Console.WriteLine(mesaj.Length.ToString());

var sonuc = mesaj.ToLower(); // hepsi küçük karakter oldu
Console.WriteLine(sonuc);

var sonuc1 = mesaj.ToUpper(); // hepsi büyük olsun
Console.WriteLine(sonuc1);

var sonuc2 = mesaj.Trim();//baştaki sondaki boşlukları sil
Console.WriteLine(sonuc2);

var sonuc3 = mesaj.Split(" "); // bir karaktere göre string dizisine ayır
Console.WriteLine(sonuc3);

var sonuc4 = mesaj[3]; // string içindeki index'e denk gelen değeri gör
Console.WriteLine(sonuc4);

var sonuc5 = mesaj.Split(" ")[3]; // bir karaktere göre string dizisine ayır
Console.WriteLine(sonuc5);

string mesaj1 = "Denizhan isimli kişi 20 yaşındadır.";
var sonuc6 = mesaj1.StartsWith("Denizhan"); //bu ile mi başladı
Console.WriteLine(sonuc6);
var sonuc7 = mesaj1.EndsWith("."); //bu ile mi bitti
Console.WriteLine(sonuc7);

var sonuc8 = mesaj1.Contains("Denizha"); //arama, var mı yok mu
Console.WriteLine(sonuc8);

var sonuc9 = mesaj1.Contains("Mehmet"); //arama, var mı yok mu
Console.WriteLine(sonuc9);

var sonuc10 = mesaj1.IndexOf("kişi"); //kaçıncı yerde var
Console.WriteLine(sonuc10);

var sonuc11 = mesaj1.IndexOf("addd"); //kaçıncı yerde var, -1 ise yok demektir
Console.WriteLine(sonuc11);

var sonuc12 = mesaj1.Substring(10);//bu stringi getir
Console.WriteLine(sonuc12);

var sonuc13 = mesaj1.Substring(0,15);//bu stringi getir
Console.WriteLine(sonuc13);