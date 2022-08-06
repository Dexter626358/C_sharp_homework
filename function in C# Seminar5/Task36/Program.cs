/* Задача 36: Задайте одномерный массив,
 заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
int elements = 10;
int result = sumOddIndexes(fillArray(elements));
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях равна: " + result);

int[] fillArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(-1000, 1000);
    }
    return array;
}

int sumOddIndexes(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}


