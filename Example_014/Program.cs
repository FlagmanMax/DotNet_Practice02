// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

void ex14()
{
    Console.Write("Число = ");
    int val1 = Convert.ToInt32(Console.ReadLine());


    int result = val1 % (7*23);

    if (result == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine("НЕ кратно, ");
    }
}

ex14();