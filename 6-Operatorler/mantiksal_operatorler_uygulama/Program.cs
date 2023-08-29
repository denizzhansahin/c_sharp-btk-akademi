string[] kontrol = new string[2];
Console.WriteLine("LÜTFEN GEREKLİ BİLGİLERİ DOLDURUNUZ!");

Console.WriteLine("Veli İzni : Evet-Hayır");
kontrol[0] = Console.ReadLine() ?? "";
if(kontrol[0]=="Evet" || kontrol[0]=="Hayır"){
    Console.WriteLine("Tamamdır");
}else{
    Console.WriteLine("Hatalı yazım, otomatik olarka Hayır atandı.");
    kontrol[0]="Hayır";
}

Console.WriteLine("Yaş yazınız : ");
kontrol[1] = Console.ReadLine() ?? "0";
if(Convert.ToInt32(kontrol[1])<0){
    Console.WriteLine("Hatalı yazım, otomatik olarka 0 atandı.");
    kontrol[1]="0";
}

if(kontrol[0]=="Evet" || Convert.ToInt32(kontrol[1])>=18){
    Console.WriteLine("Çalışma İzni Vardır");
}else{
    Console.WriteLine("Çalışma İzni Yoktur");
}



Console.WriteLine("///////////////////////////");
Console.WriteLine("Lütfen Ders Notu Yazınız : ");
var dersNotu = Convert.ToInt32(Console.ReadLine() ?? "0");
if(dersNotu<0 || dersNotu>100){
    Console.WriteLine("Hatalı ders notu , 0 otomatik olarak atandı");
}else{
    if(dersNotu<50){
        Console.WriteLine("Dersten kaldi.");
    }else{
        Console.WriteLine("Dersi Geçti.");
    }
}



Console.WriteLine("///////////////////////////");
Console.WriteLine("Lütfen Ders Ortalaması Yazınız : ");
var dersNotu1 = Convert.ToInt32(Console.ReadLine() ?? "0");

if(dersNotu1<0 || dersNotu1>100){
    Console.WriteLine("Hatalı ders ortalaması , 0 otomatik olarak atandı");
    dersNotu1=0;
}else{
    if(dersNotu1<50){
        Console.WriteLine("Dersten kaldi.");
    }else{
        Console.WriteLine("Dersi Geçti.");
    }
}

Console.WriteLine("Lütfen Zayıf Ders Var Mı Yazınız : Evet-Hayir");
var dersZayif = Console.ReadLine() ?? "Hayir";

if(dersZayif=="Evet" || dersZayif == "Hayir"){
    Console.WriteLine("Tamamdır");
}else{
    Console.WriteLine("Hatalı yazım, otomatik olarak Hayir atandır");
    dersZayif = "Hayir";
}

if(dersNotu1<=70 || dersZayif=="Hayir"){
    Console.WriteLine("Teşekkür Belgesi alamaz.");
}else{
    Console.WriteLine("Teşekkür Belgesi alabilir.");
}


Console.WriteLine("/////////////////");
Console.WriteLine("Lütfen birini seçiniz : Önlisans, Lisans");
var egitim = Console.ReadLine() ?? "Önlisans";
if (egitim == "Önlisans" || egitim == "Lisans"){
    Console.WriteLine("Tamamdır");
}else{
    Console.WriteLine("Hatali yazım , otomatik olarak Önlisans seçildi");
    egitim = "Önlisans";
}

Console.WriteLine("Sigara kullanıyor musunuz? : Evet-Hayir");
var sigara = Console.ReadLine() ?? "Hayir";
if (sigara == "Evet" || sigara == "Hayir"){
    Console.WriteLine("Tamamdır");
}else{
    Console.WriteLine("Hatali yazım , otomatik olarak Önlisans seçildi");
    sigara = "Hayir";
}

if(egitim == "Önlisans" && sigara == "Evet"){
    Console.WriteLine("İşe giremez.");
}else{
    Console.WriteLine("İşe girebilir");
}




string email = "deniz@deniz.com";
string password = "1234";
string username = "deniz";

var sonuc = ((email=="deniz@deniz.com"||username=="deniz")&&(password=="1234"))?"başarılı":"başarisiz";
Console.WriteLine(sonuc);