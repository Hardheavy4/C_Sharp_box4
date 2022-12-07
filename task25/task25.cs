//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b");
int b = Convert.ToInt32(Console.ReadLine());
int ok = a;
for (int i = 1; i < b; i++)
{
ok = ok * a;
}
Console.WriteLine("A в степени B равно: " + ok);