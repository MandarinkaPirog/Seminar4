//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A
// в натуральную степень B.


Console.Write("Введите число А:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Число А в степени В = ");
Console.Write(Math.Pow(num1,num2));
