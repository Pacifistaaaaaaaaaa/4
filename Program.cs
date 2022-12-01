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



        int num, rem, sum = 0, temp;
        //clrscr();
        Console.WriteLine("Является ли число палиндромом");
        Console.Write("Введите число");
        num = Convert.ToInt32(Console.ReadLine());
        temp = num;
        while (Convert.ToBoolean(num))
        {
            rem = num % 10;  
            num = num / 10; 
            sum = sum * 10 + rem; 
        }
        Console.WriteLine(sum);
        if (temp == sum)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
        Console.ReadLine();
