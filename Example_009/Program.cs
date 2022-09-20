// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

void PrintMaxNum()
{
    Random random = new Random();
    int number = random.Next(10,100);

    Console.WriteLine(number);

    int digit1 = number%10;
    int digit2 = number/10;

    if (digit1 > digit2)
    {
        Console.WriteLine("Наибольшее число " + digit1);
        Console.WriteLine("Наименьшнее число " + digit2);
    }
    else
    {
        Console.WriteLine("Наибольшее число " + digit2);
        Console.WriteLine("Наименьшнее число " + digit1);
    }
}

PrintMaxNum();