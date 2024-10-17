﻿// Siehe https://aka.ms/new-console-template für weitere Informationen}
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wählen Sie eine mathematische Operation aus:");
        Console.WriteLine("1: Multiplizieren");
        Console.WriteLine("2: Dividieren");
        Console.WriteLine("3: Addieren");
        Console.WriteLine("4: Potenzieren");
        Console.WriteLine("5: Wurzelziehen");
        Console.WriteLine("6: Fakultät");
        Console.WriteLine("7: Invertieren");

        int operation = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case 1:
                PerformMultiplication();
                break;
            case 2:
                PerformDivision();
                break;
            case 3:
                PerformAddition();
                break;
            case 4:
                PerformPower();
                break;
            case 5:
                PerformRoot();
                break;
            case 6:
                PerformFactorial();
                break;
            case 7:
                PerformInversion();
                break;
            default:
                Console.WriteLine("Ungültige Auswahl.");
                break;
        }
    }

    static void PerformMultiplication()
    {
        int[] numbers = ReadTwoNumbers();
        Console.WriteLine($"Ergebnis: {numbers[0]} * {numbers[1]} = {numbers[0] * numbers[1]}");
    }

    static void PerformDivision()
    {
        int[] numbers = ReadTwoNumbers();
        if (numbers[1] != 0)
            Console.WriteLine($"Ergebnis: {numbers[0]} / {numbers[1]} = {(double)numbers[0] / numbers[1]}");
        else
            Console.WriteLine("Division durch Null ist nicht erlaubt.");
    }

    static void PerformAddition()
    {
        int[] numbers = ReadTwoNumbers();
        Console.WriteLine($"Ergebnis: {numbers[0]} + {numbers[1]} = {numbers[0] + numbers[1]}");
    }

    static void PerformPower()
    {
        int[] numbers = ReadTwoNumbers();
        Console.WriteLine($"Ergebnis: {numbers[0]} ^ {numbers[1]} = {Math.Pow(numbers[0], numbers[1])}");
    }

    static void PerformRoot()
    {
        Console.WriteLine("Geben Sie eine Zahl ein:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Ergebnis: √{number} = {Math.Sqrt(number)}");
    }

    static void PerformFactorial()
    {
        Console.WriteLine("Geben Sie eine Zahl ein:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Ergebnis: {number}! = {Factorial(number)}");
    }

    static void PerformInversion()
    {
        Console.WriteLine("Geben Sie eine Zahl ein:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Ergebnis: -{number}");      
    }

    static int[] ReadTwoNumbers()
    {
        Console.WriteLine("Geben Sie die erste Zahl ein:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Geben Sie die zweite Zahl ein:");
        int number2 = Convert.ToInt32(Console.ReadLine());
        return new int[] { number1, number2 };
    }

    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }
}