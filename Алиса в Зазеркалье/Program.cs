using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Алиса_в_Зазеркалье
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Алиса в Зазеркалье");
            Console.Write("Введите значение: ");
            string name = Console.ReadLine();


            char[] vs = name.ToCharArray();
            char temp;

            for (int i = 0; i < vs.Length / 2; i++)
            {
                temp = vs[i];
                vs[i] = vs[(vs.Length - 1) - i];
                vs[(vs.Length - 1) - i] = temp;
            }

            Console.Write($"Зеркально: ");
            Console.WriteLine(new string(vs));
            Console.ReadKey();
        }
    }
}
