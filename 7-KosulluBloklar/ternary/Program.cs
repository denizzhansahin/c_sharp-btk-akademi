int sayi = 10;

var sonuc = (sayi % 2== 0) ? "sayı çift" : "sayi tek";
Console.WriteLine(sonuc);

sonuc = (sayi % 2== 0) ? 
    "sayi çift" :
     "sayi  tek";

Console.WriteLine(sonuc);


sonuc = (sayi % 2 == 0) ?
    (sayi>0) ? "sayı pozitif çift" : "sayı negatif çift":
    (sayi>0) ? "sayı pozitif tek" : "sayi negatif tek";
Console.WriteLine(sonuc);