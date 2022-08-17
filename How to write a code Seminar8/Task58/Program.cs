/*Задача 58: Задайте две матрицы. Напишите программу,
 которая будет находить произведение двух матриц.

Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:

70	61	46	69
61	119	92	76
46	92	100	88
69	76	88	114*/

int[,] matrix1 = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7}};
int[,] matrix2 = {{1, 5, 8, 5}, {4, 9, 4, 2}, {7, 2, 2, 6}, {2, 3, 4, 7}};
int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];


for(int i = 0; i < matrix1.GetLength(0); i++)
{
    for(int j = 0; j < matrix1.GetLength(1); j++)
    {
        for(int k = 0; k < result.GetLength(0); k++)
        
            result[i, j] += matrix1[i, k] * matrix2[k, j];
            Console.Write(result[i, j] + "\t"); 
    }
    Console.WriteLine();
}



