using System;
public class MainClass
{
    public static void Main(string[] args)
    {
        int a = 0;
        Console.WriteLine("Введите a:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Периметр нвадрата P={0}", a + a + a + a);
        Console.ReadKey();
    }
}