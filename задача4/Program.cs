 /*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число");
string first = Console.ReadLine();
int firstnumber = int.Parse(first);
Console.WriteLine("Введите второе число");
string second = Console.ReadLine();
int secondnumber = int.Parse(second);
Console.WriteLine("Введите третье число");
string three = Console.ReadLine();
int threenumber = int.Parse(three);
int max = firstnumber;

if (secondnumber > max); 
max = secondnumber;
if (threenumber > max);
max = threenumber;  
Console.WriteLine(max);
