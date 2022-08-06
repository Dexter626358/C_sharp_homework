/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
 Парой считаем первый и последний элемент, второй и предпоследний и т.д.
 Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */
int[] array = {6, 7, 3, 6};
int len = array.Length;
int[] result = new int[len / 2 + len % 2];
int index = 0;
if (len % 2 == 0)
{
    while(index < (len / 2))
{
    result[index] = array[index] * array[len - index - 1];
    index++;
}
} else
{
    while(index < (len / 2))
{
    result[index] = array[index] * array[len - index - 1];
    index++;
}
result[result.Length - 1] = array[len / 2];
}

for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}

