/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

int getSecondDigitFromNumber(int number)
{
    int secondNumber = (number / 10) % 10;
    return secondNumber;
}

Console.WriteLine("Введите трехзначное число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = getSecondDigitFromNumber(userNumber);
Console.WriteLine($"Для числа {userNumber} вторая цифра {secondNumber}");

