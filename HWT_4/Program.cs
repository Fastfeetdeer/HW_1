// ДЗ 1.4
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Ввидите число: ");
int N = int.Parse(Console.ReadLine());
var r = 1;
while (r <= N)
{
    if (r % 2 == 0)
        {
            Console.Write(r + ", ");
            r++;
                    }
    else
        {
            r++;
        }
}
