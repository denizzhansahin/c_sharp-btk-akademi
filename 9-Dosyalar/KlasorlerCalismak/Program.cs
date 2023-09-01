Directory.CreateDirectory("temp");
Directory.CreateDirectory("temp/deneme");
Directory.CreateDirectory("temp/deneme2");

if(Directory.Exists("temp/deneme2")){
    Directory.Delete("temp/deneme2");
}else{
    Console.WriteLine("silmek istenen klasör yok");
}

Directory.CreateDirectory("temp/deneme2");
//Directory.Move("temp/deneme2", "temp/deneme");

//string path = "/home/denshn/Masaüstü/C#-BTK/9-Dosyalar/KlasorlerCalismak/temp/deneme3";
//Directory.CreateDirectory(path);

string path  = Directory.GetCurrentDirectory();
Console.WriteLine(path);

path  = Directory.GetCurrentDirectory() + "/temp/deneme4";
Directory.CreateDirectory(path);
