var rnd = new Random();

int sayi = rnd.Next(0);
Console.WriteLine(sayi);

int sayi2 = rnd.Next(100);
Console.WriteLine(sayi2);

int sayi3 = rnd.Next(10,20);
Console.WriteLine(sayi3);

string[] takimlar = {"Beşiktaş","Galatasaray","Fenerbahçe","Trabzonspor"};
int sayi4 = rnd.Next(0,4);
Console.WriteLine(sayi4);
Console.WriteLine(takimlar[sayi4]);