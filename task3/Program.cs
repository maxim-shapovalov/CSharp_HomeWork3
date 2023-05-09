// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите положительное целое число");
int x = Convert.ToInt32(Console.ReadLine());

void Calculate(int c)
{
    int result = c * c * c;
    Console.Write(" " + result);
}

for (int i = 0; i < x; i++)
{
    Calculate(i);
} 