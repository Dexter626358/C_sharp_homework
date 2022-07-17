/* Задача 13: Напишите программу, которая выводит третью цифру
 заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/* Console.WriteLine("Введите число ");
string number = Console.ReadLine();
string startNumber = number;
if (number.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number.Length > 3)
    {
        number = (int.Parse(number) / 10) + "";


    }
    int thirdDigit = int.Parse(number) % 10;
    Console.WriteLine("Третья цифра числа " + startNumber + " " + "равна " + thirdDigit);

}
*/
// с помощью функции

string GetThirdNumber(int number)
{
    string number1 = number + "";
    string startNumber = number1;
    if (number1.Length < 3)
    {
        return "Третьей цифры нет";
    }
    else
    {
        while (number1.Length > 3)
        {
            number1 = (int.Parse(number1) / 10) + "";
        }

        return int.Parse(number1) % 10 + "";
    }
}

Console.WriteLine(GetThirdNumber(645));
Console.WriteLine(GetThirdNumber(72));
Console.WriteLine(GetThirdNumber(32679));
