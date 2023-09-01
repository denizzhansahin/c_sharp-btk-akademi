/*
Console.WriteLine("Toplama için +");
Console.WriteLine("Çıkarma için -");
Console.WriteLine("Çarpma için *");
Console.WriteLine("Bölme için /");

Console.WriteLine("Seçiniz : ");
var secim = Console.ReadLine();

Console.WriteLine("1.sayi");
var sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2.sayi");
var sayi2 = Convert.ToInt32(Console.ReadLine());

bool ok = true;
double sonuc = 0;
if(secim=="+"){
    sonuc = sayi1 + sayi2;
}else if(secim=="-"){
    sonuc = sayi1 - sayi2;
}else if(secim=="*"){
    sonuc = sayi1 * sayi2;
}else if(secim=="/"){
    if(sayi2==0){
        ok = false;
        Console.WriteLine("bölüm 0");
    }else{
        sonuc = sayi1 / sayi2;
    }
    
}else{
    ok = false;
    Console.WriteLine("yanlış seçim");
}

Console.WriteLine(sonuc);

if(ok){
    Console.WriteLine($"{sayi1} {secim} {sayi2} = {sonuc}");
}
*/

/*
Console.Write("1.yazılı : ");
int not1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2.yazılı : ");
int not2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sözlü : ");
int sozlu = Convert.ToInt32(Console.ReadLine());

var ortalama = (not1 + not2 + sozlu)/3;
int not = 0;

bool ok = false;
if(ortalama>=0 && ortalama<25){
    not = 0;
}else if(ortalama >= 25 && ortalama < 45){
    not = 1;
}else if(ortalama>=45 && ortalama<55){
    not = 2;
}else if(ortalama>=55 && ortalama<70){
    not = 3;
}else if(ortalama>=70 && ortalama<85){
    not = 4;
}else if(ortalama>=85 && ortalama<=100){
    not = 5;
}else{
    ok = false;
    Console.WriteLine("yanlış not girdiniz");
}

if(ok){
Console.WriteLine($"ortalama : {ortalama} ve notunuz : {not}");
}
*/

Console.Write("a : ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("b : ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("c : ");
int c = Convert.ToInt32(Console.ReadLine());

int enbuyuk = 0;
if(a>b && a > c){
    enbuyuk = a;
}else if(b>a && b>c){
    enbuyuk = b;
}else{
    enbuyuk = c;
}

Console.WriteLine($"en buyuk : {enbuyuk}");