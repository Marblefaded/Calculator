using System;
class Program
{
    static void Main(string[] args)
    {
        double result;


        Console.WriteLine("Enter first number");
        var a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter operation");
        var operation = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter second number");
        var b = Convert.ToDouble(Console.ReadLine());



        if (operation == '+')
        {
            result = a + b;
            Console.WriteLine($"{a} {operation} {b} = {result}");
        }

        else if (operation == '-')
        {
            result = a - b;
            Console.WriteLine($"{a} {operation} {b} = {result}");
        }

        else if (operation == '*')
        {
            result = a * b;
            Console.WriteLine($"{a} {operation} {b} = {result}");
        }

        else if (operation == '/')
        {
            result = a / b;
            Console.WriteLine($"{a} {operation} {b} = {result}");
        }

        else if (operation == '^')
        {
            result = Math.Pow(a, b);
            Console.WriteLine($"{a} {operation} {b} = {result}");
        }
        else
        {
            Console.WriteLine($"Error operator");
        }
    }


}