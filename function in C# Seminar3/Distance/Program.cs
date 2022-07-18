int[] vector1 = new int[3];
int[] vector2 = new int[3];
Console.WriteLine("Введите координыты первого вектора");
FillArray(vector1);
Console.WriteLine("Введите координыты второго вектора");
FillArray(vector2);
double distance = Math.Round(Distance(vector1, vector2), 2);
Console.Write(distance);

int[] FillArray(int[] vector)
{
    for (int i = 0; i < 3; i++)
    {
        vector[i] = int.Parse(Console.ReadLine());
    }
    return vector;
}


double Distance(int[] array1, int[] array2)
{
    double diffX = array1[0] - array2[0];
    double diffY = array1[1] - array2[1];
    double diffZ = array1[2] - array2[2];
    double distance = Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ);
    return distance;
}