// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Enter number between 1 - 4: ");
int num = int.Parse(Console.ReadLine());

if(num == 1)
{
    Console.WriteLine("X = 0 ... + ∞ \nY = 0 ... + ∞");
}
else if(num == 2)
{
    Console.WriteLine("X = 0 ... - ∞ \nY = 0 ... + ∞");
}
else if(num == 3)
{
    Console.WriteLine("X = 0 ... - ∞ \nY = 0 ... - ∞");
}
else if(num == 4)
{
    Console.WriteLine("X = 0 ... + ∞ \nY = 0 ... - ∞");
}
else
{
    Console.WriteLine("Invalid input");
}
