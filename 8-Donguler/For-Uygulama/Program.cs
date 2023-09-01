
/*
var toplam = 0;

for (var i = 1;i<=100;i++){
    toplam += i;
}
Console.WriteLine($"Toplam : {toplam}");
*/


/*
Console.WriteLine("///////////");
Console.Write("Lütfen başlangıç değeri yazınız : ");
var baslangic = Convert.ToInt32(Console.ReadLine() ?? "0");
Console.Write("Lütfen bitiş değeri yaıznı : ");
var bitis = Convert.ToInt32(Console.ReadLine() ?? "1");
Console.WriteLine($"Seçtiğiniz sayılar : Başlangıç için {baslangic} , Bitiş için {bitis}");
var toplam2 = 0;

if(baslangic<bitis){
    for(var i = baslangic; i<=bitis; i++){
    toplam2 += i;
    }
}else if(bitis<baslangic){
    for(var i = baslangic; i>=bitis; i--){
    toplam2 += i;
    }
}

Console.WriteLine($"Toplam : {toplam2}");
*/


/*
Console.WriteLine("///////////");
string[] dizi = {"denizhan","şahin"};
int dizi_sira = 1;
foreach(var i in dizi){
    Console.WriteLine($"Dizinin {dizi_sira-1}. indexinde bulunan {dizi_sira}. elemanı : {i}");
    dizi_sira += 1;
}
*/

Console.WriteLine("///////////");
int[] sayilar = {1,3,4,34,42,56,89};
foreach(var i in sayilar){
    var sonuc = (i%3==0);
    Console.WriteLine($"Bu sayı dizisi içinde bulunan {i} sayisi için 3 ile bölünme durumu : {sonuc}");
}