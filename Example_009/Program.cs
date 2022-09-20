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
        Console.WriteLine("Максимальное число " + digit1);
    }
    else
    {
        Console.WriteLine("Максимальное число " + digit2);
    }
}

PrintMaxNum();