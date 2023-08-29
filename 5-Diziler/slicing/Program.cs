string[] sehirler = {"zonguldak","rize","kocaeli","istanbul","ankara"};
var sonuc = sehirler[0..3];//0dan başla 3'e kadar,3 dahil değil
Console.WriteLine(sonuc.Length);
Console.WriteLine(sonuc[0]);

foreach(var i in sehirler){
    Console.WriteLine(i);
}

foreach(var i in sehirler[0..3]){
    Console.WriteLine(i);
}

foreach(var i in sehirler[..3]){ //baştan 3'e kadar gider
    Console.WriteLine(i);
}

foreach(var i in sehirler[2..]){//en sona 2'den başlayıp gider
    Console.WriteLine(i);
}

string il = "Kocaeli";
Console.WriteLine(il[..5]);