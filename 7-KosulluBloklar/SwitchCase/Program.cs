int gun = 1;

switch (gun) {
    case 0:
        Console.WriteLine("Pazar");
        break;
    case 1:
        Console.WriteLine("Pazartesi");
        break;
    case 2:
        Console.WriteLine("Salı");
        break;
    case 3:
        Console.WriteLine("Çarşamba");
        break;
    case 4:
        Console.WriteLine("Perşembe");
        break;
    case 5:
        Console.WriteLine("Cuma");
        break;
    case 6:
        Console.WriteLine("Cumartesi");
        break;
    default:
        Console.WriteLine("Merhaba!");
        break;
}

int gun1 = (int)DateTime.Now.DayOfWeek;

switch (gun1) {
    case 0:
        Console.WriteLine("Pazar");
        break;
    case 1:
        Console.WriteLine("Pazartesi");
        break;
    case 2:
        Console.WriteLine("Salı");
        break;
    case 3:
        Console.WriteLine("Çarşamba");
        break;
    case 4:
        Console.WriteLine("Perşembe");
        break;
    case 5:
        Console.WriteLine("Cuma");
        break;
    case 6:
        Console.WriteLine("Cumartesi");
        break;
    default:
        Console.WriteLine("Merhaba!");
        break;
}


int ay = 12;

switch (ay){
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlkbahar");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar");
        break;
    default:
        Console.WriteLine("Merhaba!!");
        break;
}