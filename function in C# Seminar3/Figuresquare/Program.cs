Console.WriteLine("Введите название фигуры");
string figure = (Console.ReadLine()).ToLower();
switch (figure)
{
    case "треугольник":
        Console.WriteLine("Введите размер основания в см");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите высоту в см");
        double height = Convert.ToDouble(Console.ReadLine());
        double tregSquare = getTriangleSquare(b, height);
        Console.WriteLine($"Площадь треугольника составляет {tregSquare} см2");
        break;

    case "круг":
        Console.WriteLine("Введите радиус см");
        double radius = Convert.ToDouble(Console.ReadLine());
        double cycSquare = getCycleSquare(radius);
        Console.WriteLine($"Площадь круга составляет {cycSquare} см2");
        break;

    case "прямоугольник":
        Console.WriteLine("Введите размер стороны один в см");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите размер стороны два в см");
        double c = Convert.ToDouble(Console.ReadLine());
        double rectSquare = getRectangleSquare(a, c);
        Console.WriteLine($"Площадь треугольника составляет {rectSquare} см2");
        break;

    default:
        Console.WriteLine("Для введенной фигуры не удалось рассчитать площадь.");
        break;
}

double getTriangleSquare(double b, double height)
{
    double square = Math.Round((0.5 * b * height), 2);
    return square;
}

double getRectangleSquare(double side1, double side2)
{
    double square = Math.Round(side1 * side2, 2);
    return square;
}

double getCycleSquare(double radius)
{
    double square = Math.Round(Math.PI * radius * radius, 2);
    return square;
}
