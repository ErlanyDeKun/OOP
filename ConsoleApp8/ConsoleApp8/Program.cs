using System;

class Program
{
    static void Main()
    {
        string s1 = "Привет";
        string s2 = "мир";
        string s3 = "C# программирование";

        Console.WriteLine($"s1 = {s1}");
        Console.WriteLine($"s2 = {s2}");
        Console.WriteLine($"s3 = {s3}\n");


        string concat1 = s1 + " " + s2;
        string concat2 = String.Concat(s1, " ", s2);
        Console.WriteLine("=== Сцепление ===");
        Console.WriteLine($"s1 + \" \" + s2       : {concat1}");
        Console.WriteLine($"String.Concat(...)  : {concat2}\n");


        string copy1 = string.Copy(s3);  
        string copy2 = s3;         
        string copy3 = new string(s3.ToCharArray()); 
        Console.WriteLine("=== Копирование ===");
        Console.WriteLine($"string.Copy          : {copy1}");
        Console.WriteLine($"= s3                 : {copy2}");
        Console.WriteLine($"new string(char[])   : {copy3}\n");


        string sub1 = s3.Substring(3);
        string sub2 = s3.Substring(0, 4);
        string sub3 = s3.Substring(3, 7);
        Console.WriteLine("=== Подстрока ===");
        Console.WriteLine($"s3.Substring(3)     : {sub1}");
        Console.WriteLine($"s3.Substring(0, 4)  : {sub2}");
        Console.WriteLine($"s3.Substring(3, 7)  : {sub3}\n");


        string sentence = "Это пример предложения для разделения";
        string[] words = sentence.Split(' ');
        Console.WriteLine("=== Разделение на слова ===");
        Console.WriteLine($"Split(' ') — {words.Length} слов:");
        for (int i = 0; i < words.Length; i++)
            Console.WriteLine($"  [{i}] {words[i]}");

        string csv = "один,два;три четыре";
        string[] parts = csv.Split(new char[] { ',', ';', ' ' });
        Console.WriteLine($"\nSplit(',', ';', ' ') — {parts.Length} частей:");
        foreach (var p in parts) Console.WriteLine($"  {p}");
        Console.WriteLine();


        string original = "Hello World";
        string inserted = original.Insert(5, ", beautiful");
        Console.WriteLine("=== Вставка ===");
        Console.WriteLine($"До     : {original}");
        Console.WriteLine($"Insert : {inserted}\n");


        string toRemove = "Hello, beautiful World";
        string removed1 = toRemove.Remove(5, 11);
        string removed2 = toRemove.Remove(5);
        Console.WriteLine("=== Удаление ===");
        Console.WriteLine($"До            : {toRemove}");
        Console.WriteLine($"Remove(5, 11) : {removed1}");
        Console.WriteLine($"Remove(5)     : {removed2}\n");


        string name = "Иван";
        int age = 25;
        double salary = 1234.56;

        string interp1 = $"Сотрудник: {name}, возраст: {age}, зарплата: {salary}";
        string interp2 = $"Зарплата: {salary:C}";
        string interp3 = $"Возраст: {age:D3}";
        string interp4 = $"Число: {salary:F2}";
        string interp5 = $"Через 5 лет: {age + 5} лет";
        string interp6 = $"Верхний регистр: {name.ToUpper()}";
        string interp7 = $"|{name,10}|{age,-5}|";

        Console.WriteLine("=== Интерполирование ===");
        Console.WriteLine(interp1);
        Console.WriteLine(interp2);
        Console.WriteLine(interp3);
        Console.WriteLine(interp4);
        Console.WriteLine(interp5);
        Console.WriteLine(interp6);
        Console.WriteLine(interp7);
    }
}