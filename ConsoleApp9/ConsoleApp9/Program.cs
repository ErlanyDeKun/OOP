using System;

class Program
{
    static void Main()
    {
        string empty = "";
        string nullStr = null;

        Console.WriteLine($"IsNullOrEmpty(\"\")   : {string.IsNullOrEmpty(empty)}");
        Console.WriteLine($"IsNullOrEmpty(null) : {string.IsNullOrEmpty(nullStr)}");
        Console.WriteLine($"IsNullOrEmpty(\"abc\"): {string.IsNullOrEmpty("abc")}");


        Console.WriteLine($"\nempty == \"\"   : {empty == ""}");
        Console.WriteLine($"empty == null  : {empty == null}");
        Console.WriteLine($"nullStr == null: {nullStr == null}");


        Console.WriteLine($"empty.Length   : {empty.Length}");


        Console.WriteLine($"empty + \"abc\"  : \"{empty + "abc"}\"");
        Console.WriteLine($"empty.ToUpper(): \"{empty.ToUpper()}\"");
        Console.WriteLine($"empty.Trim()   : \"{empty.Trim()}\"");
        Console.WriteLine($"empty.Split(',') длина: {empty.Split(',').Length}");

        Console.WriteLine($"nullStr?.Length: {(nullStr?.Length == null ? "null" : nullStr.Length.ToString())}");
        Console.WriteLine($"nullStr ?? \"x\"  : {nullStr ?? "x"}");

        Console.WriteLine($"\nIsNullOrWhiteSpace(\" \")  : {string.IsNullOrWhiteSpace(" ")}");
        Console.WriteLine($"IsNullOrWhiteSpace(null) : {string.IsNullOrWhiteSpace(nullStr)}");
    }
}