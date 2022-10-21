/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Введите пятизначное число: ");

if (number < 0)
{
    number = number * -1;
} 
if (number < 9999 || number > 99999)
{
    Console.Write("Введено неподходящее число");
}
else
{
   int num1 = number / 10000;
   int num2 = number / 1000 % 10;
   int num4 = number % 100 / 10;
   int num5 = number % 10;

   if (num1 == num5 && num2 == num4)
   {
    Console.WriteLine("Число палиндром");
   }
   else 
   {
    Console.WriteLine("Число не палиндром");
   }
}
