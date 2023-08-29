var a = true;
var b = true;
var c = false;
var d = false;

//&& ve
var sonuc = (a&&b);
sonuc = (a&&c);
Console.WriteLine(sonuc);
sonuc = (c&&d);
Console.WriteLine(sonuc);
// veya ||
sonuc = (a||b);
Console.WriteLine(sonuc);
sonuc = (c||b);
Console.WriteLine(sonuc);
sonuc = (c||d);
Console.WriteLine(sonuc);
//değil !
sonuc = !c;
Console.WriteLine(sonuc);

