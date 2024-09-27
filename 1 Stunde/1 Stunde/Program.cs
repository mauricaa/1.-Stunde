// See https://aka.ms/new-console-template for more information


bool eingabe = true;

Console.WriteLine("schreib etwas");

while (eingabe)
{
    string input = Console.ReadLine();
    string stop = "beenden";
    string lowerInput = input.ToLower();
    Console.WriteLine(input);
    if (lowerInput == stop)
    {
        eingabe = false;
    }
}
