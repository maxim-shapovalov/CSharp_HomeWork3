// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите целое пятизначное число ");
string x = Console.ReadLine();
//string x = "12321";

// Проверка на пятизначность
bool checkUnits(string value)
{
    if (value.Length == 5)
    {
        return true;
    }
    Console.WriteLine("Введенное число не пятизначное");
    return false;
}

// Проверка на палиндром
void checkString(string value)
{
    if((value[0] == value[4]) && (value[1] == value[3]))
    {
        Console.Write("Введенное число - палиндром");
    }
    else
    {
        Console.Write("Введенное число - не палиндром");
    }
}

if (checkUnits(x)) {
    checkString(x);
}