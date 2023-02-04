// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Enter X1 number: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y1 number: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter X2 number: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y2 number: ");
int y2 = int.Parse(Console.ReadLine());

int a = x1 - x2;
int b = y1 - y2;
double c = System.Math.Sqrt(a*a + b*b);

Console.WriteLine("The distans between 2 given dots is: " + c);

