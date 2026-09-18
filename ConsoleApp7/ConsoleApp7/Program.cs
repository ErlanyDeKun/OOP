using System;

class Program
{
    static void Main()
    {
     
        string s1 = "привет";
        string s2 = "привет";
        string s3 = "Привет";      
        string s4 = "привет ";       
        string s5 = "пока";
        string s6 = "при" + "вет";     
        string s7 = String.Empty;      
        string s8 = "";               

        Console.WriteLine("=== Сравнение строк через == ===");
        Console.WriteLine($"s1 == s2 : {s1 == s2}");  
        Console.WriteLine($"s1 == s3 : {s1 == s3}");  
        Console.WriteLine($"s1 == s4 : {s1 == s4}");
        Console.WriteLine($"s1 == s5 : {s1 == s5}");  
        Console.WriteLine($"s1 == s6 : {s1 == s6}"); 
        Console.WriteLine($"s7 == s8 : {s7 == s8}"); 
    }
}