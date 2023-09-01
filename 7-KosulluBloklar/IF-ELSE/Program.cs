string username = "deniz";
string password = "1234";

if(username == "deniz"){
    if(password == "1234"){
        Console.WriteLine("Merhaba Denizhan");
    }else{
        Console.WriteLine("parola yanlış");
    }
}else{
    Console.WriteLine("username yanlış");
}

if(username!="deniz"){
    Console.WriteLine("username yanlış");
}else if(password!="1234"){
    Console.WriteLine("parola yanlış");
}else{
    Console.WriteLine("Merhaba");
}

int x = 20;
int y = 20;

if(x>y){
    Console.WriteLine("x y'den büyük");
}else if(x==y){
    Console.WriteLine("x y'e eşit");
}else{
    Console.WriteLine("x y'den büyük");
}