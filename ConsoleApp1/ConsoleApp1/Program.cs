using System;

class Program
{
    static void Main()
    {
        bool @bool = true;
        byte @byte = 200;
        sbyte @sbyte = -100;
        char @char = 'A';
        decimal @decimal = 79228162514264337593543950335m;
        double @double = 3.14159;
        float @float = 3.14f;
        int @int = -2000000000;
        uint @uint = 4000000000;
        long @long = -9000000000000000000L;
        ulong @ulong = 18000000000000000000UL;
        short @short = -30000;
        ushort @ushort = 60000;
        object @object = 42;
        string @string = "привет";
        dynamic @dynamic = "динамик";

        Func<int, int> @delegate = x => x * x;

        Console.WriteLine($"{@bool} {@byte} {@sbyte} {@char} {@decimal} {@double} {@float}");
        Console.WriteLine($"{@int} {@uint} {@long} {@ulong} {@short} {@ushort}");
        Console.WriteLine($"{@object} {@string} {@dynamic} {@delegate(5)}");

        Console.Write("bool: "); @bool = bool.Parse(Console.ReadLine());
        Console.Write("byte: "); @byte = byte.Parse(Console.ReadLine());
        Console.Write("sbyte: "); @sbyte = sbyte.Parse(Console.ReadLine());
        Console.Write("char: "); @char = char.Parse(Console.ReadLine());
        Console.Write("decimal: "); @decimal = decimal.Parse(Console.ReadLine());
        Console.Write("double: "); @double = double.Parse(Console.ReadLine());
        Console.Write("float: "); @float = float.Parse(Console.ReadLine());
        Console.Write("int: "); @int = int.Parse(Console.ReadLine());
        Console.Write("uint: "); @uint = uint.Parse(Console.ReadLine());
        Console.Write("long: "); @long = long.Parse(Console.ReadLine());
        Console.Write("ulong: "); @ulong = ulong.Parse(Console.ReadLine());
        Console.Write("short: "); @short = short.Parse(Console.ReadLine());
        Console.Write("ushort: "); @ushort = ushort.Parse(Console.ReadLine());
        Console.Write("object: "); @object = Console.ReadLine();
        Console.Write("string: "); @string = Console.ReadLine();
        Console.Write("dynamic: "); @dynamic = Console.ReadLine();

        Console.WriteLine($"{@bool} {@byte} {@sbyte} {@char} {@decimal} {@double} {@float}");
        Console.WriteLine($"{@int} {@uint} {@long} {@ulong} {@short} {@ushort}");
        Console.WriteLine($"{@object} {@string} {@dynamic} {@delegate(5)}");
    }
}