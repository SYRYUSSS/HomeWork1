using System;
public class Program
{
    //Дано трехзначное число. Обнулить в нем разряд десятков.
    public static int Task1(int x)
    {
        x = x / 100 * 100 + x % 10;
        return x;
    }
    public static void Main(string[]args)
    {
        Console.WriteLine("Task 1");
        Console.WriteLine(Task1(345));
    }
}