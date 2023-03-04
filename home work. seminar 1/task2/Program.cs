// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.

// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    System.Console.WriteLine($"max= {numberA}; min={numberB}");
}
else if (numberA < numberB)
{
    System.Console.WriteLine($"max = {numberB}; min = {numberA}");
}
else if (numberA == numberB)
{
    System.Console.WriteLine($"числа равны ({numberA}={numberB})");
}