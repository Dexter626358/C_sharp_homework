﻿/*Задача 56: Задайте прямоугольный двумерный массив.
 Напишите программу, которая будет находить строку с наименьшей
 суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
int[,] array2D = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7}};

int line = getMinSum(getSuminRows(array2D)) + 1;
Console.WriteLine("Наименьшая сумма элементов находится в строке номер " + line);

int[] getSuminRows(int[,] array2D)
{
    int[] rowSum = new int[array2D.GetLength(0)];
    int sumInRow = 0; 

    for(int i = 0; i < array2D.GetLength(0); i++)
    {
        for(int j = 0; j < array2D.GetLength(1); j++)
        {
            sumInRow += array2D[i,j];
        }
        rowSum[i] = sumInRow;
        sumInRow = 0;
    }
    return rowSum;
}

int getMinSum(int[] array)
{
    int min = array[0];
    int indexMin = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
            indexMin = i;
        } 
    }
    
    return indexMin;
}




