// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

void ex16()
{
    Console.Write("Число 1 = ");
    int val1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Число 2 = ");
    int val2 = Convert.ToInt32(Console.ReadLine());

    if ((val1*val1 == val2) || (val1 == val2*val2))
    {
        Console.WriteLine("Является квадратом");
    }
    else
    {
        Console.WriteLine("НЕ является квадратом");
    }
}

ex16();