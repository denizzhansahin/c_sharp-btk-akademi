StreamWriter sw = File.CreateText("deneme.txt");
sw.WriteLine("Merhaba");
sw.WriteLine("BTK");
sw.WriteLine("Akademi");

sw.Close();


using (StreamWriter sw1 = File.CreateText("deneme.txt")){
    sw1.WriteLine("Merhaba");
    sw1.WriteLine("BTK");
    sw1.WriteLine("Akademi1");
}


using (StreamWriter sw1 = File.AppendText("deneme.txt")){
    sw1.WriteLine("Merhaba");
    sw1.WriteLine("BTK");
    sw1.WriteLine("Akademi1111111");
}

using(StreamReader sr = File.OpenText("deneme.txt")){
    var s = "";
    while((s=sr.ReadLine())!=null){
        Console.WriteLine(s);
    }
}


File.WriteAllText("deneme2.txt","merhaba");
File.WriteAllText("deneme2.txt","merhaba1");
File.AppendAllText("deneme2.txt","merhaba1");