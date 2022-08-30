﻿// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int row, int col, int min, int max) 
{    
    int[,] matrix = new int[row,col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
} 

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 3},");
            else Console.Write($"{matrix[i,j], 3}");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, -9, 9);

PrintMatrix(array2D);

Console.WriteLine("Введите номер строки: ");
int num1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите номер столбца: ");
int num2 = Convert.ToInt32(Console.ReadLine()) - 1;

void MeaningElementMatrix(int[,] arr, int numrow, int numcol)
{
if (numrow < arr.GetLength(0) &&
 numcol < arr.GetLength(1) &&
 numrow > 0 &&
 numcol > 0
 )
{
    Console.WriteLine($"Значение элемента: {array2D[numrow, numcol]}");
}
else Console.WriteLine("Значение не сущществует");
}

MeaningElementMatrix(array2D, num1, num2);

// if (numrow < array2D.GetLength(0) &&
//  numcol < array2D.GetLength(1) &&
//  numrow > 0 &&
//  numcol > 0
//  )
// {
//     Console.WriteLine(array2D[numrow, numcol]);
// }
// else Console.WriteLine("Значение не сущществует");