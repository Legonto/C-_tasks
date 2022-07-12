// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine ("Задача 1. В этой программе мы сравним два целых числа и покажем какое из них больше");
Console.WriteLine ("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA>numB)
{
    Console.WriteLine ("Число " + numA + " больше, чем число " + numB);
}
if (numA==numB)
{
Console.WriteLine ("Число " + numA + " равно " + numB);
}
else 
{
    Console.WriteLine ("Число " + numB + " больше, чем число " + numA);
}
