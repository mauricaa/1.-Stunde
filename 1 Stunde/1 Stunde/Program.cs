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
    else
    {
            if (bool.TryParse(input, out bool boolWert))
            {
                Console.WriteLine($"Der eingegebene Wert ist ein boolescher Wert: {boolWert}");
            }
            else if (int.TryParse(input, out int intWert))
            {
                if (intWert > 0)
                {
                    Console.WriteLine($"Die eingegebene Zahl ist ein Integer: {intWert}");
                }
                else
                {
                    Console.WriteLine("Gib eine natürliche Zahl ein, die größer als 0 ist.");
                }
            }
            else if (double.TryParse(input, out double doubleWert))
            {
                Console.WriteLine($"Die eingegebene Zahl ist eine Kommazahl (double): {doubleWert}");
            }
            else if (DateTime.TryParse(input, out DateTime datumWert))
            
        {
                Console.WriteLine($"Die Eingabe ist ein Datum: {datumWert.ToShortDateString()}");
            }else if (float.TryParse(input, out float floatWert))
        {
                Console.WriteLine($"Die eingegebene Zahl ist eine Kommazahl (float): {floatWert}");   
        }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Gib eine neue gültige Zahl ein.");
        }
    }
}
Console.WriteLine("Programm beendet.");