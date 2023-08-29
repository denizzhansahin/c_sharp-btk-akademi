using static System.Linq.Enumerable;

string[] isimler = new string[3];
int[,] notlar = new int[3,3];

Console.WriteLine("Ogrenci İsimlerini Yazınız : ");
foreach(var i in Range(0,isimler.Length)){
    Console.WriteLine($"{i}. Ogrenci İsmi : ");
    isimler[i] = Console.ReadLine() ?? "";
}

Console.WriteLine("Ogrenci İsimleri : ");
foreach(var i in Range(0,isimler.Length)){
    Console.WriteLine($"{i}. Ogrenci İsmi : {isimler[i]}");
}

Console.WriteLine("Ogrenci Notları Girilsin : ");
foreach(var i in Range(0,isimler.Length)){
    Console.WriteLine($"{i}. Ogrenci İsmi : {isimler[i]}");
    foreach(var k in Range(0,3)){
        notlar[i,k] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Ogrenci İsimleri ve Notları : ");
foreach(var i in Range(0,isimler.Length)){
    var toplam = 0;
    Console.WriteLine($"{i}. Ogrenci İsmi : {isimler[i]}");
    foreach(var k in Range(0,3)){
        Console.WriteLine($"{k}. Not : {notlar[i,k]}");
        toplam += notlar[i,k];
    }
    Console.WriteLine($"{i}. ogrenci olan {isimler[i]}'in ortalaması : {toplam/3}");
}