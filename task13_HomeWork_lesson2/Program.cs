/* 
 Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int getThirdDigitFromNumber(int number)
{
    while(number > 1000)
    {
        number = number / 10;
    }
        if(number > 99)
        {
            number = number % 10;
        }
        else 
            number = -1;
    return number;
}

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int thirdDigit = getThirdDigitFromNumber(userNumber);

if(thirdDigit == -1)
{
   Console.WriteLine($"Нет третьей цифры"); 
}
else
    Console.WriteLine($"Третья цифра {thirdDigit}");

