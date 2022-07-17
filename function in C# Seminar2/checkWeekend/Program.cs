/* 
Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

string CheckWeekend(int day)
{
    if (day == 6 || day == 7)
    {
        return "да"; 
    }
    if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5)
    {
        return "нет";
    }
    else
    {
        return "Такого дня не существует";
    }
}    

Console.WriteLine(CheckWeekend(1));
Console.WriteLine(CheckWeekend(2));
Console.WriteLine(CheckWeekend(3));
Console.WriteLine(CheckWeekend(4));
Console.WriteLine(CheckWeekend(5));
Console.WriteLine(CheckWeekend(6));
Console.WriteLine(CheckWeekend(7));
Console.WriteLine(CheckWeekend(8));
Console.WriteLine(CheckWeekend(9));
Console.WriteLine(CheckWeekend(10));