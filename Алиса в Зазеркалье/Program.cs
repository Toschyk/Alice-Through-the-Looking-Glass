using System;

namespace Alice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Алиса в Зазеркалье");
            Console.Write("Введите значение: ");
            string name = Console.ReadLine();

            string reversedName = ReverseString(name);

            Console.Write($"Зеркально: ");
            Console.WriteLine(reversedName);
            Console.ReadKey();
        }

        // Метод, который переворачивает строку
        public static string ReverseString(string input)
        {
            char[] vs = input.ToCharArray();
            char temp;

            for (int i = 0; i < vs.Length / 2; i++)
            {
                temp = vs[i];
                vs[i] = vs[(vs.Length - 1) - i];
                vs[(vs.Length - 1) - i] = temp;
            }

            return new string(vs);
        }
    }
}
