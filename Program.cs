using System;

public class AreAnagrams
{
    public static bool AreStringsAnagrams(string a, string b)
    {
        var contains = true;
        
        if (b.StartsWith(a) || a.StartsWith(b))
        {
            return contains;
        }

        foreach (var word in a)
        {
            contains = b.Contains(word.ToString());
            if (contains == false)
            {
                break;
            }
        }

        return contains;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(AreStringsAnagrams("momdad", "dadmom"));
        Console.WriteLine(AreStringsAnagrams("momdad", "momdad"));
        Console.WriteLine(AreStringsAnagrams("add", "addition"));
        Console.WriteLine(AreStringsAnagrams("addition", "add"));
        Console.WriteLine(AreStringsAnagrams("de", "decode"));
        Console.WriteLine(AreStringsAnagrams("de", "decrease"));
        Console.Read();
    }
}