/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;

}

int number = GetNumber("Введите трёхзначное число");
int secondDigit = (number % 100) / 10;

if (number >= 100 && number < 1000)
{
    Console.WriteLine($"Отлично, вы ввели трёхзначное число, вторая цифра вашего числа = {secondDigit}");
}
else
{
    Console.WriteLine("Вы ввели НЕ трёхзначное число");
}