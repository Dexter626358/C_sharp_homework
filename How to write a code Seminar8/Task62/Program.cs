/*Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7*/


int[,] array2D = new int[4, 4];
int count = 1;

for(int i = 0; i < array2D.GetLength(0); i++)
{
    array2D[0, i] = count;
    count++;
}
for(int j = 1; j < array2D.GetLength(1); j++)
{
    array2D[j, array2D.GetLength(1) - 1] = count;
    count++;
}
for(int i = 0; i < array2D.GetLength(0); i++)
{
    array2D[array2D.GetLength(0) - 1, array2D.GetLength(0) - 1 - i] = count;
    count++;
}
for(int j = 1; j < array2D.GetLength(0) - 1; j++)
{
    array2D[array2D.GetLength(0) - 1 - j, 0] = count;
    count++;
}
for(int i = 1; i < array2D.GetLength(0) - 1; i++)
{
    array2D[1, i] = count;
    count++;
}
for(int j = 0; j < array2D.GetLength(1) - 2; j++)
{
    array2D[2, array2D.GetLength(0) - 2 - j] = count;
    count++;
}

print2DArray(array2D);

void print2DArray(int[,] array) // функция печати двумерного массива
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t"); 
        }
        Console.WriteLine();
    }

}

