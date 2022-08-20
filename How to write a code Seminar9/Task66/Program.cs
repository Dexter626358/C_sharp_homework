/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
Console.WriteLine(SumNaturalElements(1, 15));
Console.WriteLine(SumNaturalElements(4, 8));


int SumNaturalElements(int start, int end)
{
    
    if(start == 0 && end == 0){
        return 0;
    }else if(start == end){
        return start;
    }    
     
    return start + SumNaturalElements(++start, end);
}