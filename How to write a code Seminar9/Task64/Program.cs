/*Задача 64: Задайте значения M и N. Напишите программу,
 которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8"" */
getNaturalNumbers(1, 5);
Console.WriteLine();
getNaturalNumbers(4, 8);
Console.WriteLine();
getNaturalNumbers(10, 100);

void getNaturalNumbers(int start, int end)
{
    if(start > end)  // базовый случай
    {
        return;
    }
    Console.Write(start + " ");     
    getNaturalNumbers(++start, end);  // рекурсивный случай
}