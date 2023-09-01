int i = 1;
do{
    Console.WriteLine(i);
    i++;
}while(i<=10);




Console.Write("adet : ");
int adet = Convert.ToInt32(Console.ReadLine());

string[] urunler = new string[adet];

int i1 = 0;

do{
    Console.Write("Urun adi : ");
    urunler[i1] = Console.ReadLine() ?? "";
    i1++;
}while(adet != i1);

Console.WriteLine("ürünler listeleniyor.");

for(var a = 0; a<urunler.Length;a++){
    Console.WriteLine(urunler[a]);
}