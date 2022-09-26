/* 
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

void dayOfWeek(int number)
{
    
    if(number > 5 && number < 8)
    {
        Console.WriteLine("Да, это выходной");
    }
    else if(number > 0 && number < 6)
    {
        Console.WriteLine("Это будний день");   
    }
    else
        Console.WriteLine("В неделе 7 дней");
}

Console.WriteLine("Введите цифру, обозначающую день недели");
int userNumber = Convert.ToInt32(Console.ReadLine());
dayOfWeek(userNumber);

