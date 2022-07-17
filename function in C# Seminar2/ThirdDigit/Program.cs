/* Задача 13: Напишите программу, которая выводит третью цифру
 заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите число ");
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