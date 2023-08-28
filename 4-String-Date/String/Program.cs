char cinsiyet = 'E';
string cinsiyet2 = "Erkek";
string cinsiyet3 = "E";

string? ad = Console.ReadLine();
string? soyad = Console.ReadLine();
string? yas = Console.ReadLine();

int dogumYili = 2000;
string mesaj = "Ahmet turan isimli kişi 20 yaşındadır";
//string concat
string mesaj1 = ad +" "+  soyad +" "+ "isimli kişi 20 yaşındadır";

Console.WriteLine(mesaj);
Console.WriteLine(mesaj1);


//string interpolation
string mesaj3 = $"{ad} {soyad} kişisi {yas} yaşındadır.";
Console.WriteLine(mesaj3);