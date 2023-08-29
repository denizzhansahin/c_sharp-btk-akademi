var kursAdi = ".net 7 ile c# programlama dersleri";
Console.WriteLine(kursAdi[10]);

var kursAdi1 = ".net 7 ile c# programlama dersleri".Split(' ');
Console.WriteLine(kursAdi1[1]);

//dizi tanimlama
string[] isimler = new string[5]; //bellekte beştane string alanı tanımla
isimler[0] = "Denizhan";
isimler[1] = "Şahin";
isimler[2]  = "Mehmet";
isimler[3] = "Akınol";
isimler[4] = "Hacı Ali Özdemir";

Console.WriteLine(isimler[0]);

int[] numaralar = new int[5];
numaralar[0] = 100;
numaralar[1] = 200;
numaralar[2] = 300;
numaralar[3] = 400;
numaralar[4] = 500;

Console.WriteLine(numaralar[0]);

Console.WriteLine($"{numaralar[0]} numaralı öğrencinin adı : {isimler[0]}");
Console.WriteLine($"{numaralar[1]} numaralı öğrencinin adı : {isimler[1]}");
Console.WriteLine($"{numaralar[2]} numaralı öğrencinin adı : {isimler[2]}");

//dizi tanımlama
string[] isimler1 = {"Denizhan","Şahin","Mehmet","Akınol"};
int[] numaralar1 = {100,200,300,400};
Console.WriteLine($"{numaralar1[0]} numaralı öğrencinin adı : {isimler1[0]}");
Console.WriteLine($"{numaralar1[1]} numaralı öğrencinin adı : {isimler1[1]}");
Console.WriteLine($"{numaralar1[2]} numaralı öğrencinin adı : {isimler1[2]}");
Console.WriteLine($"{numaralar1[3]} numaralı öğrencinin adı : {isimler1[3]}");
