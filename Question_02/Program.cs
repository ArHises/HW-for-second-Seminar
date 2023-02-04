// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Enter 1st number: ");
int first = int.Parse(Console.ReadLine());

Console.WriteLine("Enter 2nd number: ");
int second = int.Parse(Console.ReadLine());

if( first*first == second){

    Console.WriteLine($"{first}^2 = {second}");
}
else{
    
    Console.WriteLine("First number is not a square of the second one");
}