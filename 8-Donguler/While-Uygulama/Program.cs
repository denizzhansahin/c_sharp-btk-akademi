var rnd = new Random();
var tahmin = rnd.Next(1,100);

var limit = 5;
var kontrol = 0;

var kullanici = 0;

Console.WriteLine($"Tahmin edilmesi gereken sayı : {tahmin}");
while(kontrol<=limit-1){
    Console.WriteLine($"Lütfen bir sayı yazınız : Kalan hakkınız : {limit} için {limit-kontrol}");
    kullanici = Convert.ToInt32(Console.ReadLine() ?? "0");
    if(kullanici==tahmin){Console.WriteLine("Oyun bitti! Doğru Tahmin");break;}else{Console.WriteLine("Yeniden deneyiniz!");}
    kontrol++;
}