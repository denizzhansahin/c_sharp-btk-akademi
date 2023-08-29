var a = 10;
var b = 5;
var c = 20;

var sonuc = (c-a)*b;
Console.WriteLine(sonuc);

int? a1 = 50;
int b1 = 20;
var sonuc1 = a1+b1;
Console.WriteLine(sonuc1);

int? a2 = null;
var sonuc2 = a2+b1;
Console.WriteLine(sonuc2);

a = 10;
b = 20;
a=b--;
Console.WriteLine($"a : {a} ve b : {b}");

Console.Write("sayı : ");
int sayi = int.Parse(Console.ReadLine() ?? "0");
var sonuc3 = sayi%2;
if(sonuc3==0){
    Console.WriteLine($"{sayi} bir çift sayıdır.");
}else{
    Console.WriteLine($"{sayi} bir tek sayıdır.");

}