﻿//Задача 2
//Напишите программу, которая на вход принимает два
//числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

/*Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"число {number1} больше {number2}");
}
else
{
    Console.WriteLine($"число {number1} меньше {number2}");
}
*/



/*Задача 4
Напишите программу, которая принимает на вход три 
числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
int max;

if (number1>number2)
max = number1;
else
max = number2;
if (number3>number2)
max = number3;
Console.WriteLine($"Максимальное число {max}");
*/


/*Задача 6
Напишите программу, которая на вход принимает число
и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

/*Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
 
 if (N % 2 == 0)
 {
    Console.WriteLine($"{N} Чётное число");
 }
 
 else
 {
    Console.WriteLine($"{N} Нечётное число");
 }
*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int H = 1;
while (H<=N)
{
if(H%2 == 0)
{
 Console.WriteLine($"{H}");
}
H++;
}