Console.WriteLine("Введите 5-е число");
string number = Console.ReadLine();
isPolindrom(number);

void isPolindrom(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
