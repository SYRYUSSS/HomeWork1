using System;
using System.Drawing;
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
    //Создать функцию, которая возвращает минимум из двух переданных вещественных чисел. 
    public static double Task4(double x1,double x2)
    {
        if (x1 < x2)
            return x1;
        else
            return x2;
    }
    //Даны целые числа A и B. Найти произведение всех чётных целых чисел от A до B включительно.
    public static double Task5(int a,int b)
    {
        double prod = 1;
        for (int i=a;i<=b;i++)
        {
            if (i % 2 == 0)
                prod *= i;
        }
        return prod;
    }
    //Дано целое число K и набор ненулевых целых чисел; признак его завершения — число 0.
    //Вычислить количество чисел в наборе, меньших K, а также количество чисел, делящихся на K нацело.
    public static (int,int) Task6(int k, List<int> numbers)
    {
        int count = 0;
        int countmod = 0;
        foreach (int i in numbers)
        {
            if (k < i)
            {
                count += 1;   
            }
            if (k % i == 0)
                countmod += 1;
           
        }
        return (countmod, count);
    }
    // Описать перечислимый тип Seasons (времена года). Создать метод, который по номеру месяца [1..12] возвращает время года.
    public static string Task7(int k)
    {
        switch (k)
        {
            case 1: return "Зима";
            case 2: return "Зима";
            case 3: return "Весна";
            case 4: return "Весна";
            case 5: return "Весна";
            case 6: return "Лето";
            case 7: return "Лето";
            case 8: return "Лето";
            case 9: return "Осень";
            case 10: return "Осень";
            case 11: return "Осень";
            case 12: return "Зима";
            default: return "нет столько месяцев";
        }

    }
    //Описать метод, выводящий на консоль N строк "Месяц №<номер месяца>, его сезон: <сезон для этого месяца>". Номера месяцев генерируются случайно.
    public static void Task8(int N)
    {
        Random random = new Random();

        for (int i = 0; i < N; i++)
        {
            int monthNumber = random.Next(1, 13);
            string season = Task7(monthNumber);
            Console.WriteLine($"Месяц №{monthNumber}, его сезон: {season}");
        }
    }
    public static void Main(string[]args)
    {
        Console.WriteLine("Task 1");
        Console.WriteLine(Task1(345));
        Console.WriteLine("Task 2");
        Console.WriteLine(Task2(4,5));
        Console.WriteLine("Task 3");
        Console.WriteLine(Task3( 3, 4,5));
        Console.WriteLine("Task 4");
        Console.WriteLine(Task4(3,5));
        Console.WriteLine("Task 5");
        Console.WriteLine(Task5(3, 9));
        List<int> numbers = new List<int>();
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                if (number == 0)
                    break;
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Ошибка: введите целое число.");
            }
        }
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Task 6");
        Console.WriteLine(Task6(4, numbers));
        Console.WriteLine("Task 7");
        Console.WriteLine(Task7(a));
        Console.WriteLine("Task 8");
        Task8(b);
    }
}