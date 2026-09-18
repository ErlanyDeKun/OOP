using System;

class Program
{
    static void Main()
    {
        CheckedFunc();
        UncheckedFunc();

        void CheckedFunc()
        {
            Console.WriteLine("=== checked ===");
            try
            {
                checked
                {
                    int max = int.MaxValue;
                    Console.WriteLine($"max      = {max}");
                    int result = max + 1;
                    Console.WriteLine($"max + 1  = {result}");
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Исключение: {e.Message}");
            }
        }

        void UncheckedFunc()
        {
            Console.WriteLine("\n=== unchecked ===");
            unchecked
            {
                int max = int.MaxValue; 
                Console.WriteLine($"max      = {max}");
                int result = max + 1;
                Console.WriteLine($"max + 1  = {result}");
            }
        }
    }
}