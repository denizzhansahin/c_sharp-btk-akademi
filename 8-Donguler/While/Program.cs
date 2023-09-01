var i = 0;

while(i<10){
    Console.WriteLine(i);
    i++;
}

string[] isimler = {"denizhan","şahin"};
var i1 = 0;
while(i1<isimler.Length){
    Console.WriteLine(isimler[i1]);
    i1++;
}

var secim = "e";
var sayac = 1;
var toplam = 0;

while(secim=="e"){
    Console.WriteLine($"{sayac}. sayı : ");
    toplam += Convert.ToInt32(Console.ReadLine() ?? "0");
    Console.Write("devam etmek istiyor musunuz?(e/h)");
    secim = Console.ReadLine() ?? "h";
    sayac++;
}
Console.WriteLine($"{sayac} adet sayısının toplamı : {toplam}");