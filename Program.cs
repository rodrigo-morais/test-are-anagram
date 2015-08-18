using System;

public class AreAnagrams
{
    private static bool isPrefix(string a, string b){
        return b.StartsWith(a) && a.Length > 1 && b != a;
    }

    public static bool AreStringsAnagrams(string a, string b)
    {
        var contains = true;

        if(isPrefix(a,b) || isPrefix(b,a))
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
        Console.WriteLine(AreStringsAnagrams("carringf", "crease"));
        Console.Read();
    }
}