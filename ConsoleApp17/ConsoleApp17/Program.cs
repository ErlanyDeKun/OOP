using System;

class Program
{
    static void Main()
    {
        (int, string, char, string, ulong) tuple = (42, "привет", 'A', "мир", 18000000000000000000UL);

        var (i1, s1, c1, t1, u1) = tuple;
        Console.WriteLine($"1) var:  {i1}, {s1}, {c1}, {t1}, {u1}");

        (int i2, string s2, char c2, string t2, ulong u2) = tuple;
        Console.WriteLine($"2) явные типы:   {i2}, {s2}, {c2}, {t2}, {u2}");

        (var i3, string s3, var c3, string t3, var u3) = tuple;
        Console.WriteLine($"3) смешанно:     {i3}, {s3}, {c3}, {t3}, {u3}");

        int i4; string s4; char c4; string t4; ulong u4;
        (i4, s4, c4, t4, u4) = tuple;
        Console.WriteLine($"4) существующие: {i4}, {s4}, {c4}, {t4}, {u4}");

        var (id, _, _, name, _) = tuple;
        Console.WriteLine($"5) через _:      id = {id}, name = {name}");

        (_, _, char letter, _, _) = tuple;
        Console.WriteLine($"6) только 3-й:   letter = {letter}");

        var (first, _, _, _, last) = tuple;
        Console.WriteLine($"7) 1-й и 5-й:    {first}, {last}");
    }
}