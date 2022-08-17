/*Задача 56: Задайте прямоугольный двумерный массив.
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

int min = rowSum[0];
int indexMin = 0;

for(int i = 0; i < rowSum.Length; i++)
{
    if(rowSum[i] < min)
    {
        min = rowSum[i];
        indexMin = i;
    } 
}
int line = indexMin + 1;
Console.WriteLine("Наименьшая сумма элементов находится в строке номер " + line + " и равна " + rowSum[indexMin]);






