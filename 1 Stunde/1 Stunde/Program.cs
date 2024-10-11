// Siehe https://aka.ms/new-console-template für weitere Informationen
Console.WriteLine("Schreibe einen Satz der a, e, i, o, u enthält");
string inputText = Console.ReadLine();
string lowerInput = inputText.ToLower(); 

foreach (char letter in lowerInput)
{
    if (lowerInput.ContainsKey(letter))
    {
        lowerInput[letter]++;
    }
}

foreach (var vowel in lowerInput)
{
    Console.WriteLine($"Anzahl {vowel.Key}: {vowel.Value}");
}
    }
}

