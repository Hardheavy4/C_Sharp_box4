//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Random array = new Random();
int[]n = new int[8];
for (int i = 0; i < n.Length; i++)
{
n[i] = new Random().Next(-10,10);
Console.Write(n[i] +",");
}
//line for commit 