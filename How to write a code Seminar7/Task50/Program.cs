/*Задача 50. Напишите программу, которая на вход принимает
 позиции элемента в двумерном массиве, и
  возвращает значение этого элемента или же указание,
   что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Random rnd = new Random();
int randomNumber = rnd.Next(0, 100);
int[,] array = GetArray();
FillArray(array);
if(CheckNumber(array, randomNumber))
{
    Console.WriteLine("Число " + randomNumber + " есть в массиве");
} else
{
    Console.WriteLine("Числа " + randomNumber + " в массиве нет");
}

PrintArray(array); // оставил вывод на печать для проверки

int[,] GetArray()  // получаем массив случайной размерности
{
    
    int row = rnd.Next(1, 10);
    int col = rnd.Next(1, 10);
    int[,] array = new int[row, col];
    return array;
}

int[,] FillArray(int[,] array) // заполняем массив случайными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(0, 100); 
        }
        
    }
    return array; 
        
    

}

Boolean CheckNumber(int[,] array, int number) // проверяем наличие значения в массиве
{
    Boolean flag = true;
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == number)
            {
                   flag = true;
                   return flag; 
            } else
            {
                flag = false;
            }
            

             
        }
        
    }
    return flag; 
        
} 

void PrintArray(int[,] array)  // выводим массив на печать
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
