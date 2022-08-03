/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());
int result = getPower(num1, num2);
Console.WriteLine(result);
int getPower(int num1, int num2)
{
    int power = num1;
    for (int i = 1; i < num2; i++)
    {
        power *= num1;
    }
    return power;
}
