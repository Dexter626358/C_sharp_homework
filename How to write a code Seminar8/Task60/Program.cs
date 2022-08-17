/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив,
  добавляя индексы каждого элемента.

массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)*/
int[,,] array3D = new int[2, 2, 2];
//int[,,] array3D = {{{12}, {22}}, {{45}, {53}}};
Random rnd = new Random();
for(int i=0; i < array3D.GetLength(0); i++)
{
    for(int j=0; j < array3D.GetLength(1); j++)
    {
        for(int k=0; k < array3D.GetLength(2); k++)
        {
            array3D[i, j, k] = rnd.Next(10, 100);
            Console.Write(array3D[i, j, k] + "(" + i + ", " + j + ", " + k + ")" + " ");
        }
    }
    Console.WriteLine();
}

