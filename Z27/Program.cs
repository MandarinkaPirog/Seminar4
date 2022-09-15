//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int sum = Sumfun(num1);
Console.Write("Сумма цифр в данном числе = ");
Console.Write(sum);
int Sumfun(int sum1)
{
    int sum = 0;
    while ( sum1 > 0)
    {
      sum += sum1 % 10;
      sum1 /= 10;
    }
    return sum;
}