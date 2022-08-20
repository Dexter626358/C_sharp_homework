/* Задача 68: Напишите программу вычисления функции Аккермана с помощью
 рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29*/

Console.WriteLine(Akkerman(2, 3)); // 9
Console.WriteLine(Akkerman(0, 0)); // 1
Console.WriteLine(Akkerman(2, 1)); // 5
Console.WriteLine(Akkerman(3, 2)); // 29


int Akkerman(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    } else if(m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }

    return Akkerman(m - 1, Akkerman(m, n - 1));
    
    

}