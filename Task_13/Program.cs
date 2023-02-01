/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        int thirdDigit = number % 10;
        Console.WriteLine($"Третья цифра вашего числа = {thirdDigit}");
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
    return number;
}

int number = GetNumber("Введите число");