/*Задача 47. Задайте двумерный массив размером m×n,
 заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
Random rnd = new Random();
Double[,] array = GetArray();
FillArray(array);
PrintArray(array);

Double[,] GetArray()  // получаем массив случайной размерности
{
    
    int row = rnd.Next(1, 10);
    int col = rnd.Next(1, 10);
    Double[,] array = new Double[row, col];
    return array;
}

Double[,] FillArray(Double[,] array) // заполняем массив случайными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(rnd.NextDouble(), 3); 
        }
        
    }
    return array; 
        
    

}


void PrintArray(Double[,] array)  // выводим массив на печать
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t"); 
        }
        Console.WriteLine();
        
    }

}
