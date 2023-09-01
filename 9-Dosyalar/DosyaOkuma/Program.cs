StreamReader sr = File.OpenText("deneme.txt");
var s = "";
// Console.WriteLine(sr.ReadLine());
// Console.WriteLine(sr.ReadLine());

while((s = sr.ReadLine()) != null){
    Console.WriteLine(s);
}


string sonuc = File.ReadAllText("deneme.txt");
Console.WriteLine(sonuc);

string[] sonuc1 = File.ReadAllLines("deneme.txt");
Console.WriteLine(sonuc1[0]);
Console.WriteLine(sonuc1[1]);