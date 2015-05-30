using System;
using System.Collections.Generic;
using System.Collections.Immutable;  // NuGet
using System.Linq;

namespace ImmutableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IImmutableList<string> nforza = ImmutableList<string>.Empty
                .AddRange(new [] { "Ronald", "Thomas", "Erik" });

            int nforza2012Count = nforza.Count();
            IEnumerable<string> nforza2012 = nforza;

            nforza = nforza.Add("Rick");

            Console.WriteLine(nforza2012Count);
            foreach (var item in nforza2012)
            {
                Console.WriteLine(item);
            }
        }
    }
}
