﻿// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// int x = 1;
// double y = 0.1;
// double z = x + y;
// Console.WriteLine(z);
//Конвертация в вещественные числа
//Convert.ToDouble()

double[] CreateArrayRnd(int size, int min, int max) 
{    
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i = i + 1) // i = i - 1   ....  i -= 2 ..... i--
    {
        array[i] = rnd.NextDouble() + rnd.Next(min, max);
        array[i] = Math.Round(array[i], 2);
    }
    return array;
} 

void PrintArray(double[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) 
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

double[] arr = CreateArrayRnd(10, 1, 10);
PrintArray(arr);

double SummMinMax(double[] array)
{
    double numMax = array[0];
    double numMin = array[0];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (numMax < array[i]) numMax = array[i];
        if (numMin > array[i]) numMin = array[i];
    }
    double diff = numMax - numMin;
    return diff;
}
Console.WriteLine($"Разница между мах и мin значением массива {Math.Round(SummMinMax(arr), 2)}");
