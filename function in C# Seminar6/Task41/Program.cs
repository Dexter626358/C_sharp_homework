/* Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
Console.WriteLine("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine());
int countPositive = 0;
int readNumber;
for (int i = 1; i <= m; i++)
{
    Console.WriteLine("Введите число " + i);
    readNumber = int.Parse(Console.ReadLine());
    if (readNumber > 0) countPositive++;
}
Console.WriteLine("Количество положительных чисел равно " + countPositive);
