/* Задача 10: Напишите программу, которая принимает
 на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/*Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
int secondDigit = (number / 10) % 10;
Console.WriteLine("Вторая цифра введенного числа равна " + secondDigit);
*/
void GetSecondNumber(int number)
{
    int secondDigit = (number / 10) % 10;
    Console.WriteLine("Вторая цифра введенного числа равна " + secondDigit);
    
}
GetSecondNumber(456);
GetSecondNumber(782);
GetSecondNumber(918);
GetSecondNumber(324);

