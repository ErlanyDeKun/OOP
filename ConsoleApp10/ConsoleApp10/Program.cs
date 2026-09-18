using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello World");

        Console.WriteLine($"Исходная строка : \"{sb}\"");
        Console.WriteLine($"Length = {sb.Length}\n");

        sb.Remove(5, 6); 
        Console.WriteLine($"После Remove(5, 6)   : \"{sb}\"");

        sb.Append("!!!"); 
        Console.WriteLine($"После Append(\"!!!\")  : \"{sb}\"");

        sb.Insert(0, ">>> ");    
        Console.WriteLine($"После Insert(0, ...) : \"{sb}\"");

        Console.WriteLine($"\nИтоговая строка  : \"{sb}\"");
        Console.WriteLine($"Length = {sb.Length}");
    }
}