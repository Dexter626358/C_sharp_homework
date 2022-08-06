/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
 Парой считаем первый и последний элемент, второй и предпоследний и т.д.
 Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */
int[] array = {1, 2, 3, 4, 5, 6, 7};
int[] result = new int[array.Length / 2 + 1];

if (array.Length % 2 == 0)
{
    printArray(multArray(array));
} else
{
    result = multArray(array);
    result[result.Length - 1] = array[array.Length / 2];
    printArray(result);
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

}
    
int[] multArray(int[] array)
{
    int len = array.Length;
    int[] newArray = new int[len / 2 + len % 2];
    int index = 0;
    while(index < (len / 2))
    {
        newArray[index] = array[index] * array[len - index - 1];
        index++;
    }
    return newArray; 
}
