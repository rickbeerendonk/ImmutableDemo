using System;
using System.Collections.Immutable;

namespace ImmutableList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = ImmutableList<int>.Empty
                .Add(5)
                .Add(10)
                .Add(15)
                .Add(20);
            var builder = list1.ToBuilder();

            builder.Add(3);
            builder.Add(6);
            builder.Add(9);

            var list2 = builder.ToImmutable();

            Console.WriteLine("List1");
            Console.WriteLine("Count: " + list1.Count);
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("List2");
            Console.WriteLine("Count: " + list2.Count);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
