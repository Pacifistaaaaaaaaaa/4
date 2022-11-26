void Zadacha21()
{
    Console.WriteLine("Первая точка");
    int x = Convert.ToInt32(Console.ReadLine());
    int y = Convert.ToInt32(Console.ReadLine());
    int z = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Вторая точка");
    int x1 = Convert.ToInt32(Console.ReadLine());
    int y1 = Convert.ToInt32(Console.ReadLine());
    int z1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Расстояние = {Math.Sqrt(Math.Pow((x1-x), 2) + Math.Pow((y1-y), 2) + Math.Pow((z1-z), 2))}");
}


Zadacha21();