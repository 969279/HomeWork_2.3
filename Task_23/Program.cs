/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int number = ReadInt("Введите число: ");
if (number == 0)
{
    Console.WriteLine("0");
}
else if (number < 0)
    {
    DegNegativ(number);
    }
    else 
    {
    DegPositiv(number);
    }

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void DegNegativ(int number)
{
    int count = -1;
    while (count > number)
    {    
    Console.Write(count * count * count + ", ");
    count = count + -1;
    }
Console.Write(count * count * count + ".");
}

void DegPositiv(int number)
{
    int count = 1;
    while (count < number)
    {    
    Console.Write(count * count * count + ", ");
    count++;
    }
Console.Write(count * count * count + ".");
}
