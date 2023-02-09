// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void LineDist(int xa, int ya, int za, int xb, int yb, int zb) //квадрат(x2-x1)2+(y2-y1)2+(z2-z1)2
{
    Double Distance = Math.Sqrt((Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)));
    double result = Math.Round(Distance, 2); // округление вывел в отдельную строку для удобства чтения
    Console.WriteLine($"A ({xa}, {ya}, {za}); B ({xb}, {yb}, {zb}) -> {result}");
}

int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// Ввод данных от пользователя
int xa = GetNum("Введите координаты Xa - ");
int ya = GetNum("Введите координаты Ya - ");
int za = GetNum("Введите координаты Za - ");
int xb = GetNum("Введите координаты Xb - ");
int yb = GetNum("Введите координаты Yb - ");
int zb = GetNum("Введите координаты Zb - ");

// Решение задачи
LineDist(xa, ya, za, xb, yb, zb);