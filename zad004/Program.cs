// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: "); // выводится окно: "Введите первое число"
int a = Convert.ToInt32(Console.ReadLine()); // 
Console.WriteLine("Введите второе число: "); // выводится окно: "Введите второе число"
int b = Convert.ToInt32(Console.ReadLine()); // 
Console.WriteLine("Введите третье число: "); // выводится окно: "Введите третье число"
int c = Convert.ToInt32(Console.ReadLine());// 

if(a > b & a > c) // одно число больше чем остальные два
{
    Console.WriteLine($"{a} maximum");
}
else if (b > c & b > a) // одно число больше чем остальные два
{
    Console.WriteLine($"{b} maximum");
}
else if (c > a & c > b) // одно число больше чем остальные два
{
    Console.WriteLine($"{c} maximum");
}
else if (c == a & c == b) // при условии что все числа равны
{
    Console.WriteLine("введено одно и тоже число");
}
else if (a > b & b == c) // одно число больше остальных двух равных между собой
{
    Console.WriteLine($"{a} maximum");
}
else if (b > a & a == c) // одно число больше остальных двух равных между собой
{
    Console.WriteLine($"{b} maximum");
}
else if (c > a & a == b) // одно число больше остальных двух равных между собой
{
    Console.WriteLine($"{c} maximum");
}
else if (a > c & a == b ) // два равны между собой и больше третьего
{
    Console.WriteLine($"{a} maximum");
}
else if (b > a & b == c) // два равны между собой и больше третьего
{
    Console.WriteLine($"{b} maximum");
}
else if (c > b & c == a) // два равны между собой и больше третьего
{
    Console.WriteLine($"{c} maximum");
}