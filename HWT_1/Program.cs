// ДЗ 1.1
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if(a > b)
{
    System.Console.WriteLine($"Число {a} большее, число {b} меньшее");
}
else
{
    System.Console.WriteLine($"Число {b} большее, число {a} меньшее");
}