/* Дополнительное задание: Напишите программу, которая принимает на вход число N и выводит все простые числа в промежутке от 0 до N (включительно). После, попробуйте поэксперментировать с величиной значения N и понаблюдать
 за тем, как оно влияет на время выполнения программы.
 */
 Console.WriteLine("Введите число: ");
 int num = int.Parse(Console.ReadLine());
 bool flag = true;
 
 for (int i = 2; i <= num; i++)
 {
    int s=(int)Math.Sqrt(i);
    for (int j = 2; j <= s; j++)
    {
        if (i % j == 0)
        {
            flag = false;
            
        }
    }
    
    if (flag) 
    {
        Console.Write(i + " ");
    }
    flag = true;
        
         
    
    
         
 }
 
    
    
 

