int x = 10;
int y = x;

Console.WriteLine(x);
Console.WriteLine(y);

x = 20;

Console.WriteLine(x);
Console.WriteLine(y);

int[] x1 = { 10, 20,};
int[] y1 = x1;
Console.WriteLine(x1[0]);
Console.WriteLine(y1[0]);

x1[0] = 30;

Console.WriteLine(x1[0]);
Console.WriteLine(y1[0]);
