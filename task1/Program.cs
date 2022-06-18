// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 
// 3, 5 -> 243 (3⁵)
// 
// 2, 4 -> 16

using System;
using static System.Console;
Clear();

Write ("Введите число: ");
int n = Convert.ToInt32(ReadLine());    
Write ("Введите степень: ");
int d = Convert.ToInt32(ReadLine());    

WriteLine($"Число {n} в степени {d} равно - {exponentiate(n, d)}");

int exponentiate(int number, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result *= number;
    }
    return result;
}