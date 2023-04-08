// Задача 2. Напишите программу, которая принимает на вход 2 числа и выдает, 
//какое число больше, а какое меньше

System.Console.WriteLine("Введите первое целое число");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе целое число");
int b = int.Parse(Console.ReadLine());

if (a>b)
{
    System.Console.WriteLine("Первое число больше второго");
}
else
{
    System.Console.WriteLine("Второе число больше первого");
}

//Задача 4. Напишите программу, которая принимает на вход 3 числа и выдает максимальное из этих чисел.

System.Console.WriteLine("Введите первое целое число");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе целое число");
int b = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите третье целое число");
int c = int.Parse(Console.ReadLine());
int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

System.Console.WriteLine("Максимальное число: " + max);

//Задача 6. Напишите программу, которая принимает на вход число и выдает является ли оно четным или нет.

System.Console.WriteLine("Введите первое целое число");
int a = int.Parse(Console.ReadLine());

if (a%2==0)
{
    System.Console.WriteLine("Число является четным");
}
else
{
     System.Console.WriteLine("Число является нечетным");
}

// Задача 8..................

System.Console.WriteLine("Введите целое число");
int limit = int.Parse(Console.ReadLine());
System.Console.WriteLine("Вот четные числа до указанного числа (включительно): ");

for (int i = 0; i <= limit; i++)
{
   if (i%2==0)
   {
    System.Console.Write(i+" ");
   }
}