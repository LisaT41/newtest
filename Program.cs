// 1: Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число больше, a какое число меньше.

// a = 5; b = 7 -> max = 7, min = 5
// a = -9; b = -3 -> max = -3, min = -9

System.Console.WriteLine("Enter firs number");
string value;
value = System.Console.ReadLine();
int numberA = Convert.ToInt32(value);

System.Console.WriteLine("Enter second number");
value = Console.ReadLine();
int numberB = Convert.ToInt32(value);