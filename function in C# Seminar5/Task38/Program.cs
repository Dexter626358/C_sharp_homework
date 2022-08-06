/* Задача 38: Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */
int elements = 10;
int[] newArray = new int[elements];
newArray = fillArray(elements);
int maxMinDiff = getMax(newArray) - getMin(newArray);
Console.WriteLine("Разница между максимальным и минимальным элементом массива равна:" + maxMinDiff);


int[] fillArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(-1000, 1000);
    }
    return array;
}

int getMin(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }
    return min;
}

int getMax(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
    }
    return max;
}