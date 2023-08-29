Console.WriteLine("Lütfen Yaş Yazınız : ");
var yas = Convert.ToInt32(Console.ReadLine() ?? "0");

if(yas>=18){
    Console.WriteLine("Oy kullanabilir");
}else{
    Console.WriteLine("Oy kullanamaz");
}

if(yas>0){
    Console.WriteLine("Sayı işareti pozitif");
}else{
    Console.WriteLine("Sayı işareti negatif");
}

if(yas%2==0){
    Console.WriteLine("Sayı çift sayıdır");
}else{
    Console.WriteLine("Sayı tek sayıdır");
}
