/*
 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число");
int numberN = int.Parse(Console.ReadLine());
int numberN2 = 1;
for (int i = numberN2; i<=numberN; i++);
(i % 2 == 0);
{
   Console.WriteLine(i); 
}
