/*Write a program that finds the greatest of given 5 variables.*/


using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please give a five variables");
        int v0 = int.Parse(Console.ReadLine());
        int v1 = int.Parse(Console.ReadLine());
        int v2 = int.Parse(Console.ReadLine());
        int v3 = int.Parse(Console.ReadLine());
        int v4 = int.Parse(Console.ReadLine());
        int n = 0;

        if (n < v1)
        {
            n = v1;
        }
        if (n < v2)
        {
            n = v2;
        }
        if (n < v3)
        {
            n = v3;
        }
        if (n < v4)
        {
            n = v4;
        }
        if (n < v0)
        {
            n = v0;
        }
        Console.WriteLine("The biggest number is {0}",n);
    }
}
