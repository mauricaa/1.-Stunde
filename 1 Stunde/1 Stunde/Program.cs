
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bitte geben Sie etwas ein:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            Console.WriteLine($"Sie haben die Zahl {number} eingegeben was möchten sie ausführen?");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Multiplikation");
            Console.WriteLine("3) Division");
            Console.WriteLine("4) Fakultaet");
            Console.WriteLine("5) Wurzelziehen");

            string operation = Console.ReadLine();

            switch (operation)
            {
                case "1": 
                    Console.WriteLine("Gib eine zweite Zahl ein:");
                    if (int.TryParse(Console.ReadLine(), out int number2))
                    {
                        Console.WriteLine($"Ergebnis: {number + number2}");
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe.");
                    }
                    break;

                case "2": 
                    Console.WriteLine("Geben Sie eine zweite Zahl für die Multiplikation ein:");
                    if (int.TryParse(Console.ReadLine(), out int number3))
                    {
                        Console.WriteLine($"Ergebnis: {number * number3}");
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe.");
                    }
                    break;

                case "3": 
                    Console.WriteLine("Geben Sie eine zweite Zahl für die Division ein:");
                    if (int.TryParse(Console.ReadLine(), out int number4) && number4 != 0)
                    {
                        Console.WriteLine($"Ergebnis: {(double)number / number4}");
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe.");
                    }
                    break;

                case "4": 
                    Console.WriteLine($"Ergebnis: {Fakultaet(number)}");
                    break;

                case "5": 
                    Console.WriteLine($"Ergebnis: {Math.Sqrt(number)}");
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Sie haben eine Zeichenkette eingegeben. Was wollen Sie damit machen?");
            Console.WriteLine("1) Alle Selbstlaute (a,e,i,o,u) entfernen");
            Console.WriteLine("2) Die Zeichenkette umdrehen");
            Console.WriteLine("3) Die Anzahl an Zeichen ausgeben");

            string stringOperation = Console.ReadLine();

            switch (stringOperation)
            {
                case "1": 
                   
                    Console.WriteLine("Case 1 funktioniert nicht :(");
                    break;

                case "2":
                    string reversed = ReverseString(input);
                    Console.WriteLine($"Ergebnis: {reversed}");
                    break;

                case "3": 
                    Console.WriteLine($"Anzahl der Zeichen: {input.Length}");
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }
        }
    }

    static int Fakultaet(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

//1. theoretische: if Bedingungen, switch, for, string
//2. theoretische: Clean Code das man es besser erkent bzw verstehen kann lesen. CamelCasing, DRY, 
//3. theoretische: bei parse muss man catch einbauen sonnst ist es sehr gefährlich
//4. theoretische: Integer mit dem Wert 42 und heisst myInt
