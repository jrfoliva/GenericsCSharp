using System;
namespace GenericsCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many values?: ");
            int qtd = Convert.ToInt32(Console.ReadLine());

            PrintService<int> ps = new PrintService<int>(); //set to int, generic class
            for(int i = 1; i <= qtd; i++)
            {
                Console.Write($"{i}#: ");
                int value = Convert.ToInt32(Console.ReadLine());
                ps.AddValue(value);
            }
            ps.Print();
            Console.WriteLine("First: "+ps.First());
        }
    }
}