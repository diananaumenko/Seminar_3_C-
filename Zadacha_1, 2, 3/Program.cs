// Задача 1
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится 
// эта точка и показывает диапазон возможных координат точек в этой четверти (x и y).
// A (2, 3) -> 1 четверть, x > 0, y > 0
// A (-5, -8) -> 3 четверть, x < 0, y < 0

// Console.WriteLine("Введите ось х: ");
// string text = Console.ReadLine();
// int x = Convert.ToInt32(text);
// Console.WriteLine("Введите ось у: ");
// string text_1 = Console.ReadLine();
// int y = Convert.ToInt32(text_1);

// if (x == 0 || y == 0)
// {
//     Console.WriteLine("Нуль не вводи");
// }

// if (x < 0 && y < 0)
// {
//     Console.WriteLine("3-ая четверть");
// }
// if (x < 0 && y > 0)
// {
//    Console.WriteLine("2-ая четверть");
// }
// if (x > 0 && y < 0)
// {
//     Console.WriteLine("4-ая четверть");
// }
// if (x > 0 && y > 0)
// {
//     Console.WriteLine("1-ая четверть");
// }

// Задача 2 
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.Write("Введите число x1: ");
// string text_x1 = Console.ReadLine();
// int x1 = Convert.ToInt32(text_x1);

// Console.Write("Введите число y1: ");
// string text_y1 = Console.ReadLine();
// int y1 = Convert.ToInt32(text_y1);

// Console.Write("Введите число x2: ");
// string text_x2 = Console.ReadLine();
// int x2 = Convert.ToInt32(text_x2);

// Console.Write("Введите число y2: ");
// string text_y2 = Console.ReadLine();
// int y2 = Convert.ToInt32(text_y2);

// double x = Math.Pow((x2 - x1), 2);
// double y = Math.Pow((y2 - y1), 2);
// double AB = Math.Sqrt((x + y));
// Console.WriteLine(" ");
// Console.WriteLine($"Расстояние между точками А и В: {AB}");

// Задача 3 
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Вариант 1
// Console.Write("Введите число N: ");
// string text_N = Console.ReadLine();
// double N = Convert.ToInt32(text_N);
// double x = 0;
// double y = 0;
// while (x <= N)
// {
//     y = Math.Pow(x, 2);
//     Console.WriteLine(y);
//     x++;
// }
//
// Вариант 2
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; Console.Write(i * i + ", "), i++);