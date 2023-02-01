/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Это выходной день");
    }
    else if (number >= 1 && number < 6)
    {
        Console.WriteLine("Это будний день");
    }
    else
    {
        Console.WriteLine("Нет такого дня недели");
    }
    return number;
}

int number = GetNumber("Введите число");