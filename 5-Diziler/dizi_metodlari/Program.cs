string[] sehirler = {"istanbul","rize","kocaeli"};
sehirler[0]="sakarya";
Console.WriteLine(sehirler[0]);
sehirler.SetValue("yozgat",1);
Console.WriteLine(sehirler[1]);
Console.WriteLine(sehirler.GetValue(1));
Console.WriteLine(sehirler.Length);//uzunluk
Console.WriteLine(Array.IndexOf(sehirler,"yozgat"));//arama yapma
Array.Sort(sehirler);//alfabetik sıralama
Console.WriteLine(sehirler.GetValue(1));

int[] plakalar = {67,53,41};
Console.WriteLine(plakalar.GetValue(0));
Array.Sort(plakalar);//sayısal sıralama
Console.WriteLine(plakalar.GetValue(0));
Array.Reverse(plakalar);//ters çevirme
Console.WriteLine(plakalar.GetValue(0));
Array.Clear(sehirler);//eleman silme, hepsini silme
Console.WriteLine(sehirler.GetValue(0));
Array.Clear(plakalar);
Console.WriteLine(plakalar.GetValue(0));//default değer gelir, çünkü dizi silindi

int[] plakalar2 = new int[3]; //default olarak üç alana 0 ataması yapılır
Console.WriteLine(plakalar2.GetValue(0));
plakalar2.SetValue(1,0);
plakalar2.SetValue(2,1);
plakalar2.SetValue(3,2);
Console.WriteLine(plakalar2.GetValue(0));
Array.Clear(plakalar2,0,1); //0 indexten itibaren 1 tane sil
Console.WriteLine(plakalar2.GetValue(0));
