string isim = "Denizhan ŞAHİN";

for(var i = 0; i<isim.Length;i++){
    if(isim[i]=='H'){
        break;
    }
    Console.WriteLine(isim[i]);
}

int x = 0;
while(x<5){
    x++;
    if(x==3){
        continue;
    }
    Console.WriteLine(x);
}