// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void Show2Digit()
{
    Console.Write("Введите трехзначное число ");
    int number = Convert.ToInt32(Console.ReadLine());

    int digit2 = (number%100)/10;

    Console.WriteLine("Вторая цифра введенного трехзначного числа = " + digit2);
}

Show2Digit();
