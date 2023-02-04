// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Enter number of day: ");
int day = int.Parse(Console.ReadLine());

if(day == 7){
    Console.WriteLine("Weekend :)");
}
else{
    Console.WriteLine("go to work :(");
}