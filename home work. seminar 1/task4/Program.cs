// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("введите число A " );
int A= Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите число B " );
int B= Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите число C " );
int C= Convert.ToInt32(Console.ReadLine());
if(A > B && A > C)
{
    System.Console.WriteLine($"максимальное число {A}");
}
else if (B > A && B > C)
{
    System.Console.WriteLine($"максимальное число {B}");
}
else if (C > A && C > B)
{
    System.Console.WriteLine($"максимальное число {C}");
}

