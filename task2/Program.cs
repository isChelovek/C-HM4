// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 
// 452 -> 11
// 
// 82 -> 10
// 
// 9012 -> 12

using System;
using static System.Console;
Clear();

Write ("Введите число: ");
int n = Convert.ToInt32(ReadLine());    

WriteLine($"Сумма чисел в числе {n} равна - {sumNumbers(n)}");

int sumNumbers (int number)
{
    int result = 0;
    for (int i = 1; i <= n; i*=10)
    {
        result += n / i % 10;
    }
    return result;
}
