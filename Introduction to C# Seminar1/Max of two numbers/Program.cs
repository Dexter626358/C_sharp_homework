/* Задача 2: Напишите программу, которая на вход принимает
 два числа и выдаёт максимальное из этих чисел. */
 Console.WriteLine("Ведите первое число: ");
 int number1 = int.Parse(Console.ReadLine());
 Console.WriteLine("Ведите второе число: ");
 int number2 = int.Parse(Console.ReadLine());
 int max = - 2000000000;
 if (number1 > number2) max = number1;
 if (number2 > number1) max = number2;
 if (number1 == number2)
 {
    Console.WriteLine("Числа равны");
 } 
 else
 {
    Console.WriteLine("Максимум равен " + max);
 }

 
