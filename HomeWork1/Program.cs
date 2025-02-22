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
    }
    public static void Main(string[]args)
    {
        Console.WriteLine("Task 1");
        Console.WriteLine(Task1(345));
        Console.WriteLine("Task 2");
        Console.WriteLine(Task2(4,5));
    }
}