Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
CubNumbers(number);


void CubNumbers(int num)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write(i * i * i + " ");
    }
}
