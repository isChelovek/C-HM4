// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 
// 6, 1, 33 -> [6, 1, 33]

using System;
using static System.Console;
Clear();

Write("Массив: ");

printArray(fillArray(8, 0, 10));

int[] fillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
       array[i] = new Random().Next(min, max +1);
    }
    return array;
}

void printArray(int[] array)
 {
    Write("[");
     for (int i = 0; i < array.Length; i++)
     {
        Write(array[i]);
        Write(i < array.Length-1 ? ", " : "");
     }
     Write("]");
 }


