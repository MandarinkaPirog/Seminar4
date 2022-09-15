//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int size =8;
int [] array = new int[size];
array2(array);
Console.Write( string.Join(",", array));
void array2 (int[] array)
{
    for (int i=0;i < array.Length;i++)
    array[i]= new Random().Next(0,100);
}