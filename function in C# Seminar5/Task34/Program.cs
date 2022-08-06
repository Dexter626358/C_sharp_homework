/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
int elements = 100;

int result = evenNumbers(fillArray(elements));
Console.WriteLine("Количество четных чисел равно: " + result);


int[] fillArray(int size)
{
    int[] positivArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        positivArray[i] = rnd.Next(100, 1000);
    }
    // String sentence = string.Join(", ", positivArray);
    // Console.WriteLine(sentence);
    return positivArray;
}
int evenNumbers(int[] array)
{
    int countEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) countEven++;
    }
    return countEven;
}


