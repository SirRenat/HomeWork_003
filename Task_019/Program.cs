// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



void CheckNumber(int num)
{
    if (!(num > 9999 && num < 100000))
    {
        Console.WriteLine("Вы ввели некорректное число");
        return;
    }
}

int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// Ввод данных
int num = GetNum("Введите пятизначное число - ");
CheckNumber(num);

// Выво данных
// Polindrome(num);