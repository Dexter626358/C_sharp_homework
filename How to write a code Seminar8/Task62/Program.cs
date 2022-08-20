/*Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7*/


int[,] array2D = new int[6, 6];
int count = 1;
int len = array2D.GetLength(0);

for(int col = 0; col < len; col++)  // первая строка
{
    array2D[0, col] = count;
    count++;
}
for(int row = 1; row < len; row++) // последний столбец
{
    array2D[row, len - 1] = count;
    count++;
}
for(int col = 1; col < len; col++) // последняя строка
{
    array2D[len - 1, len - 1 - col] = count;
    count++;
}
for(int row = 1; row < len - 1; row++) // первый столбец
{
    array2D[len - 1 - row, 0] = count;
    count++;
}


int c = 1;
int d = 1;
while(count < len * len)
{
    //Движемся вправо.
    while (array2D[c, d + 1] == 0) {
        array2D[c, d] = count;
        count++;
        d++;
    }

    //Движемся вниз.
    while (array2D[c + 1, d] == 0) {
        array2D[c, d] = count;
        count++;
        c++;
    }

    //Движемся влево.
    while (array2D[c, d - 1] == 0) {
        array2D[c, d] = count;
        count++;
        d--;
    }

    //Движемся вверх.
    while (array2D[c - 1, d] == 0) {
        array2D[c, d] = count;
        count++;
        c--;
    }
    for (int x = 0; x < len; x++) {
            for (int y = 0; y < len; y++) {
                if (array2D[x, y] == 0) {
                    array2D[x, y] = count;
                }
            }
        }
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

