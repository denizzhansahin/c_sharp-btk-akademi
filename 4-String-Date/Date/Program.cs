var simdi = DateTime.Now;
DateTime simdi2 = DateTime.Now;

Console.WriteLine("SİMDİ " + simdi);
Console.WriteLine("SİMDİ2 " + simdi2);

//metodlar
Console.WriteLine(simdi.Year);
Console.WriteLine(simdi.Month);
Console.WriteLine(simdi.Day);
Console.WriteLine(simdi.DayOfWeek);
Console.WriteLine(simdi.Hour);
Console.WriteLine(simdi.Minute);
Console.WriteLine(simdi.Second);
Console.WriteLine(simdi.Millisecond);

//olusturma
DateTime dt = new DateTime(2018,6,10,12,15,13,14);
Console.WriteLine(dt);
DateTime dt2 = dt.AddYears(1);;
DateTime dt3 = dt.AddHours(1);;
Console.WriteLine(dt2);
Console.WriteLine(dt3);

var fark = simdi - dt;
Console.WriteLine(fark.TotalDays);
Console.WriteLine(fark.TotalHours);