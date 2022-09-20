// Задача 13: Напишите программу, которая с помощью
// деления выводит третью цифру заданного числа или
// сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void Show3Digit()
{
    Console.Write("Введите число : ");
    int val1 = Convert.ToInt32(Console.ReadLine());

    if ( val1 / 100 == 0)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        int search = Math.Abs(val1);
        while (search > 1000)
        {
            search = search/10;
        }
        int digit3 = search%10 ;
        Console.WriteLine("Третья цифра "+ digit3);
    }
}

Show3Digit();