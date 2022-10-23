/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int x1 = ReadInt("Введите X точки A: ");
int y1 = ReadInt("Введите Y точки A: ");
int z1 = ReadInt("Введите Z точки А: ");
int x2 = ReadInt("Введите X точки B: ");
int y2 = ReadInt("Введите Y точки B: ");
int z2 = ReadInt("Введите Z точки В: ");

int sqr_X = (x2 - x1) * (x2 - x1);
int sqr_Y = (y2 - y1) * (y2 - y1);
int sqr_Z = (z2 - z1) * (z2 - z1);
double distance = Math.Sqrt(sqr_X + sqr_Y + sqr_Z);
Console.WriteLine("Расстояние равно: " + distance);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
