string kursAdi = ".NET 7 ile C# Programlama Dili";
//1 kaç karakter ve
//2 hepsini kucuk karakter yap
//3 '.' ile mi baslamaktadir
//4 'C#' bilgisi hangi konumdadır?
//5 string 'C#' bilgisi iceriyormu
//6 'Dili' kelimesi yerine 'Dersleri' yaziniz. (Replace)

//1
var karakterSayisi = kursAdi.Length;
Console.WriteLine(karakterSayisi);
//2
var kucukHarf = kursAdi.ToLower();
Console.WriteLine(kucukHarf);
//3
var nokta = kursAdi.StartsWith('.');
Console.WriteLine("string . ile başlıyor : " + nokta);
//4
var konum = kursAdi.IndexOf("C#");
Console.WriteLine("konum : " + konum);
//5
var iceriyormu = kursAdi.Contains("C#");
Console.WriteLine($"C# içeriyor mu : {iceriyormu}");
//6
var guncellenmisString = kursAdi.Replace("Dili","Dersleri");
Console.WriteLine(guncellenmisString);