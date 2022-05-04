string ?x = Console.ReadLine();
string ?y = Console.ReadLine();
string ?z = Console.ReadLine();

int xint = int.Parse(x!);
int yint = int.Parse(y!);
int zint = int.Parse(z!);


Console.WriteLine((xint+yint)*zint);
Console.WriteLine(xint*yint + yint*zint);