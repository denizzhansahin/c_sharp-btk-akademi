// int a;
// Console.WriteLine("");

int maas = 12; //null direkt atanmaz
string isim = null;
Console.WriteLine(maas);

int? maas1 = null;
Console.WriteLine(maas1);

if(maas1.HasValue){
    Console.WriteLine(maas1);
}else{
    Console.WriteLine("Maas yok");
}

Console.WriteLine(maas1.GetValueOrDefault());