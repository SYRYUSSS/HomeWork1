using System;
public class Program
{
    //Дано трехзначное число. Обнулить в нем разряд десятков.
    public static int Task1(int x)
    {
        x = x / 100 * 100 + x % 10;
        return x;
    }
    //Даны координаты поля шахматной доски x, y (целые числа, лежащие в диапазоне 1–8).
    //Учитывая, что левое нижнее поле доски (1, 1) является черным, вывести, какой цвет имеет поле с данными координатами.
    public static String Task2(int x,int y)
    {
        if ((x + y) % 2 == 1)
        {
            return "black";
        }
        else
            return "White";
        
        if (y > 8)
        {
            throw new ArgumentException("y mustn't be >8");
        }
        if (x>8)
        {
            throw new ArgumentException("x mustn't >8");
        }
        if (y<1)
        {
            throw new ArgumentException("y mustn't be 1<");
        }
        if (x<1)
        {
            throw new ArgumentException("x mustn't be 1<");
        }
    }
    //Даны числа A, B, C(число A не равно 0). Вернуть количество вещественных корней квадратного уравнения Ax2+Bx+c=0
    public static double Task3(int a,int b,int c)
    {
        int d = b^2 - 4 * a * c;
        double x1 = ((-b) + Math.Sqrt(d))/(2*a);
        double x2 = ((-b) - Math.Sqrt(d)) / (2 * a);
        if (x1 == x2)
            return 1;
        else
            return 2;
        if (d < 0)
            return 0;

    }
    public static void Main(string[]args)
    {
        Console.WriteLine("Task 1");
        Console.WriteLine(Task1(345));
        Console.WriteLine("Task 2");
        Console.WriteLine(Task2(4,5));
        Console.WriteLine("Task 3");
        Console.WriteLine(Task3( 3, 4,5));
    }
}