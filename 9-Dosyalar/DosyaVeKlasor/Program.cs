string rootpath  = Directory.GetCurrentDirectory();
Console.WriteLine(rootpath);

//klasörler
string[] dirs = Directory.GetDirectories(rootpath,"*",SearchOption.TopDirectoryOnly);

foreach(var dir in dirs){
    Console.WriteLine(dir);
}

//dosyalar
string[] files = Directory.GetFiles(rootpath,"*",SearchOption.AllDirectories);

foreach(var file in files){
    Console.WriteLine(file);
}

//dosyalar
string[] files1 = Directory.GetFiles(rootpath,"*.txt",SearchOption.AllDirectories);

foreach(var file1 in files1){
    Console.WriteLine(file1);
    Console.WriteLine(Path.GetExtension(file1));//uzantı
    Console.WriteLine(Path.GetFileNameWithoutExtension(file1));//uzantı olmadan dosya adı
    Console.WriteLine(Path.GetFileName(file1));//dosya bilgisi

    var info  = new FileInfo(file1);
    Console.WriteLine($"{Path.GetFileName(file1)} : {info.Length}");

}


//dosyalar
string source_path  = Directory.GetCurrentDirectory() + "/img";
string dest_path  = Directory.GetCurrentDirectory() + "/images/";

string[] files2 = Directory.GetFiles(source_path,"*",SearchOption.AllDirectories);

foreach(var file2 in files2){
    Console.WriteLine(file2);
    Console.WriteLine(Path.GetExtension(file2));//uzantı
    Console.WriteLine(Path.GetFileNameWithoutExtension(file2));//uzantı olmadan dosya adı
    Console.WriteLine(Path.GetFileName(file2));//dosya bilgisi

    var info  = new FileInfo(file2);
    Console.WriteLine($"{Path.GetFileName(file2)} : {info.Length}");

    if(!Directory.Exists(dest_path)){
        Directory.CreateDirectory(dest_path);
    }

    //File.Copy(file2,$"{dest_path}{Path.GetFileName(file2)}"); //dosya, isim seç

    string name = Path.GetRandomFileName() + Path.GetExtension(file2); // rastgele isim üretmek
    File.Copy(file2,$"{dest_path}{name}"); //dosya, isim seç

}