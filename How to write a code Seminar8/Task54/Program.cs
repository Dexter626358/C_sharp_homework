/*Задача 54: Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию элементы
 каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8*/


int[,] array2d = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

for(int i = 0; i < array2d.GetLength(0); i++)
{
    int[] array1D = new int[array2d.GetLength(1)];
    for(int j = 0; j < array2d.GetLength(1); j++)
    {
        array1D[j] = array2d[i,j];   
    }
    int[] tmpArray = SortedArray(array1D);
    for(int k = 0; k < array2d.GetLength(1); k++)
    {
        array2d[i, k] = tmpArray[k]; 
    }

}

print2DArray(array2d);


int[] SortedArray(int[] array)  // Функция сортировки одномерного массива
{
    int[] sortArray = new int[array.Length];
    int startIndex = 0;
    int cmt;
    while(startIndex < array.Length)
    {
        int min = array[startIndex];
        for(int i = startIndex; i < array.Length; i++)
        {
            if(array[i] < min)
            {
                cmt = min;
                min = array[i];
                array[i] = cmt;
            }
        }
        sortArray[startIndex] = min;
        startIndex++;    
    }
    return sortArray;
}


void print2DArray(int[,] array) // функция печати двумерного массива
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " "); 
        }
        Console.WriteLine();
    }

}

