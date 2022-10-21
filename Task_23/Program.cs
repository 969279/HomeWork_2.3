/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
 int num = ReadInt("Введите число: ");
 int count = 1;
if (num < 0)
{
    Console.Write("Введите положительное число");
}
else 
{
 while (count < num)
 {    
    Console.Write(count * count * count + ", ");
    count++;
 }
Console.Write(count * count * count + ".");
}