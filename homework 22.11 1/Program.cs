//Задание 1
//using System;

//class Program
//{
//    static int[] GetNumbers(int[] numbers, Predicate<int> condition)
//    {
//        int count = 0;

//        foreach (int number in numbers)
//        {
//            if (condition(number))
//                count++;
//        }

//        int[] result = new int[count];
//        int index = 0;

//        foreach (int number in numbers)
//        {
//            if (condition(number))
//            {
//                result[index] = number;
//                index++;
//            }
//        }

//        return result;
//    }

//    static bool IsEven(int number)
//    {
//        return number % 2 == 0;
//    }

//    static bool IsOdd(int number)
//    {
//        return number % 2 != 0;
//    }

//    static bool IsPrime(int number)
//    {
//        if (number < 2)
//            return false;

//        for (int i = 2; i < number; i++)
//        {
//            if (number % i == 0)
//                return false;
//        }

//        return true;
//    }

//    static bool IsFibonacci(int number)
//    {
//        int a = 0;
//        int b = 1;

//        while (a < number)
//        {
//            int temp = a;
//            a = b;
//            b = temp + b;
//        }

//        return a == number;
//    }

//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 13, 21 };

//        Predicate<int> even = IsEven;
//        Predicate<int> odd = IsOdd;
//        Predicate<int> prime = IsPrime;
//        Predicate<int> fibonacci = IsFibonacci;

//        Console.WriteLine("Парные числа:");
//        Console.WriteLine(string.Join(", ", GetNumbers(numbers, even)));

//        Console.WriteLine("Непарные числа:");
//        Console.WriteLine(string.Join(", ", GetNumbers(numbers, odd)));

//        Console.WriteLine("Простые числа:");
//        Console.WriteLine(string.Join(", ", GetNumbers(numbers, prime)));

//        Console.WriteLine("Числа Фибоначчи:");
//        Console.WriteLine(string.Join(", ", GetNumbers(numbers, fibonacci)));
//    }
//}


//Задание 2
//using System;

//class Program
//{
//    static void ShowTime()
//    {
//        Console.WriteLine(DateTime.Now.ToLongTimeString());
//    }

//    static void ShowDate()
//    {
//        Console.WriteLine(DateTime.Now.ToShortDateString());
//    }

//    static void ShowDay()
//    {
//        Console.WriteLine(DateTime.Now.DayOfWeek);
//    }

//    static double TriangleArea(double a, double h)
//    {
//        return a * h / 2;
//    }

//    static double RectangleArea(double a, double b)
//    {
//        return a * b;
//    }

//    static void Main()
//    {
//        Action time = ShowTime;
//        Action date = ShowDate;
//        Action day = ShowDay;

//        Console.WriteLine("Поточное время:");
//        time();

//        Console.WriteLine("Поточная дата:");
//        date();

//        Console.WriteLine("Поточный день недели:");
//        day();

//        Func<double, double, double> triangle = TriangleArea;
//        Func<double, double, double> rectangle = RectangleArea;

//        Console.WriteLine("Площадь треугольника: " + triangle(10, 5));
//        Console.WriteLine("Площадб прямоугольника: " + rectangle(10, 5));
//    }
//}
