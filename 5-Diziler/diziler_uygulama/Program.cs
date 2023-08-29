using static System.Linq.Enumerable;

var ogrenciler = new string[3];
var notlar = new int[3];

foreach (var i in Range(0,3)){
    Console.WriteLine($"{i}. Öğrenci Adı : ");
    ogrenciler[i] = Console.ReadLine() ??"";

    Console.WriteLine($"{i}. Öğrenci Notlar : ");
    notlar[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Alınan Değerler : ");
foreach (var i in Range(0,3)){
    Console.WriteLine($"{i}. Öğrenci Adı : {ogrenciler[i]}");
    Console.WriteLine($"{i}. Öğrenci Notlar : {notlar[i]}");

}

Console.WriteLine(ogrenciler.Length);

Console.WriteLine("Alınan Değerler : ");
foreach (var i in Range(0,2)){
    Console.WriteLine($"{i}. Öğrenci Adı : {ogrenciler[i]}");
    Console.WriteLine($"{i}. Öğrenci Notlar : {notlar[i]}");

}

var toplam = 0;

foreach (var i in Range(0,notlar.Length)){
    toplam += notlar[i];
    Console.WriteLine($"{i}. Ogrenci Notu : {notlar[i]}");
}

Console.WriteLine($"Genel Not Toplamı : {toplam}, Genel Not Ortalaması : {toplam/(notlar.Length)}");