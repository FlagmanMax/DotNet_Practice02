// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

void isWeekend()
{
    Console.Write("Введите номер дня недели - число от 1 до 7: ");
    int dayOfWeek = Convert.ToInt32(Console.ReadLine());

    if ((dayOfWeek < 1) || (dayOfWeek > 7))
    {
        Console.WriteLine("Ошибка ввода"); 
    }
    else
    {
        int[] days={0,0,0,0,0,1,1};
        if (days[dayOfWeek-1] == 1)
        {
            Console.WriteLine("Да, это выходной");
        }
        else
        {
        Console.WriteLine("Нет, это рабочий день"); 
        }
    }
}

isWeekend();
