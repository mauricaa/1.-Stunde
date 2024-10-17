// Siehe https://aka.ms/new-console-template für weitere Informationen
Console.WriteLine("Schreibe einen Satz, der a, e, i, o, u enthält:");
string inputText = Console.ReadLine();
string lowerInput = inputText.ToLower();

var vowelCount = new Dictionary<char, int>
{
    {'a', 0},
    {'e', 0},
    {'i', 0},
    {'o', 0},
    {'u', 0}
};

foreach (char letter in lowerInput)
{
    if (vowelCount.ContainsKey(letter))
    {
        vowelCount[letter]++;
    }
}

foreach (var vowel in vowelCount)
{
    Console.WriteLine($"Anzahl {vowel.Key}: {vowel.Value}");
}