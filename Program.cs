// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


begin:
Console.Write("Введите число больше 1: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a <= 1)
{
    System.Console.WriteLine("неверный ввод");
    goto begin;
} 

int b = 2;

while (b <= a)
{
    System.Console.WriteLine(b);
    b = b + 2;
}

