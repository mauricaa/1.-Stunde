// See https://aka.ms/new-console-template for more information
bool eingabe = true;

Console.WriteLine("Gib eine natürliche Zahl ein oder schreibe 'beenden', um das Programm zu beenden:");
while (eingabe)
{
    string input = Console.ReadLine();
    string stop = "beenden";
    string lowerInput = input.ToLower();

    if (lowerInput == stop)
    {
        eingabe = false;
    }
    else
    {
        try
        {
            int zahl = int.Parse(input);
            if (zahl > 0)
            {
                Console.WriteLine($"Die Zahl {zahl} wurde eingegeben");
            }
            else
            {
                Console.WriteLine("gibe eine Zahl ein natürlche Zahl ein die grösser als 0 ist");
            }
        }
             catch (FormatException)
        {
            Console.WriteLine("Ungültige Eingabe. Gib eine neue gültige Zahl ein.");
        }
    }
}
Console.WriteLine("Programm beendet.");