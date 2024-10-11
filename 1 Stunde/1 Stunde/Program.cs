// See https://aka.ms/new-console-template for more information
bool eingabe = true;

Console.WriteLine("Gib eine Zahl ein oder schreibe 'beenden', um das Programm zu beenden:");
while (eingabe)
{
    string input = Console.ReadLine();
    string stop = "beenden";
    string lowerInput = input.ToLower();

    if (lowerInput == "beenden")
    {
        eingabe = false;
    }
    else if (int.TryParse(input, out int intWert))
    {
        if (intWert > 0)
        {
            Console.WriteLine($"Die eingegebene Zahl ist ein Integer: {intWert}");

            // Auswahl der mathematischen Operation
            Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 3 ein, um eine Mathematische Operation auszuwählen:");
            Console.WriteLine("1) Quadrat");
            Console.WriteLine("2) Wurzel");
            Console.WriteLine("3) Fakultät");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "1":
                    Console.WriteLine($"Das Quadrat von {intWert} ist: {intWert * intWert}");
                    break;

                case "2":
                    Console.WriteLine($"Die Wurzel von {intWert} ist: {Math.Sqrt(intWert)}");
                    break;

                case "3":
                    Console.WriteLine($"Die Fakultät von {intWert} ist: {Fakultaet(intWert)}");
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl. Bitte eine Zahl zwischen 1 und 3 wählen.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Gib eine natürliche Zahl ein, die größer als 0 ist.");
        }
    }
    else
    {
        Console.WriteLine("Ungültige Eingabe. Gib eine neue gültige Zahl ein.");
    }
}

Console.WriteLine("Programm beendet.");

static long Fakultaet(int n)
{
    long result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}