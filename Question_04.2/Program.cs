// Найти расстояние между точками в пространстве 3D

Console.WriteLine("Enter X1 number: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y1 number: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Z1 number: ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter X2 number: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y2 number: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Z2 number: ");
int z2 = int.Parse(Console.ReadLine());

int a = x1 - x2;
int b = y1 - y2;
int z = z1 - z2;
double c = System.Math.Sqrt(a*a + b*b + z*z);

Console.WriteLine("The distans between 2 given points is: " + c);
