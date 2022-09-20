// 12. Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно числу
// 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

void ex11()
{
    Console.Write("Число 1 = ");
    int val1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Число 2 = ");
    int val2 = Convert.ToInt32(Console.ReadLine());

    int result = val2 % val1;

    if (result == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine("НЕ кратно, " + result);
    }
}

ex11();