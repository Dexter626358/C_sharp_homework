int [,] array = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
string t = "";
Console.WriteLine("Введите координаты точки (через пробел):");
t = Console.ReadLine();
string[] tv = t.Split(' ').Where(x=>x !="").ToArray();
int row = int.Parse(tv[0]);
int col = int.Parse(tv[1]);
bool flag = false;

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        if (i == row && j == col)
        {
            flag = true;
            break;
        }
    }
}
if (flag)
{
    Console.WriteLine("Значение элемента равно " + array[row, col]);
} else
{
    Console.WriteLine("Такого элемента нет");
}
