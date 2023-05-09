// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

// A (3,6,8); B (2,1,-7), -> 15.84; 
// A (7,-5, 0); B (1,-1,9) -> 11.53 */


// Чтение с консоли
int ReadValue(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Вычисление
void Calculate(int a, int b, int c )
{
    double length = Math.Sqrt(a * a + b * b + c * c);
    Console.WriteLine("Расстояние между точками в пространстве = " + length);
    return;
}

int x1 = ReadValue("Введите х1: ");
int y1 = ReadValue("Введите y1: ");
int z1 = ReadValue("Введите z1: ");
int x2 = ReadValue("Введите х2: ");
int y2 = ReadValue("Введите y2: ");
int z2 = ReadValue("Введите z2: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

Calculate(A, B, C);

