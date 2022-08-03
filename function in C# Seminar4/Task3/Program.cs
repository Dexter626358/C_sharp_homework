/* Задача 29: Напишите программу, которая задаёт массив
 из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
    array[i] = rnd.Next(-100, 100);
}

Console.WriteLine();
Console.Write("[");
string newStr = String.Join(", ", array);
Console.WriteLine(newStr + "]");




