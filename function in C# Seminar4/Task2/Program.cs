/* Задача 27: Напишите программу, которая принимает на вход
 число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

Console.WriteLine("Введите число");
String number = Console.ReadLine();
int sumDigits = 0;
for (int i = 0; i < number.Length; i++)
{
    sumDigits += int.Parse(number[i].ToString());
    
}
Console.WriteLine(sumDigits);
