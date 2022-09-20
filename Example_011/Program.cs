// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

void Delete2Digit()
{
 Random random = new Random();
    int number = random.Next(100,1000);

    Console.WriteLine(number);

    int digit1 = number%10;
    int digit3 = number/100;

    int result = digit1 + digit3*10;

    Console.WriteLine("Удалили второй разряд " + result);
}

Delete2Digit();