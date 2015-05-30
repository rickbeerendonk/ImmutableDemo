using System;
using System.Collections.Generic;
using System.Linq;

namespace MutableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> nforza = new List<string> { "Ronald", "Thomas", "Erik" };

            int nforza2012Count = nforza.Count();
            IEnumerable<string> nforza2012 = nforza;

            nforza.Add("Rick");

            Console.WriteLine(nforza2012Count);
            foreach (var item in nforza2012)
            {
                Console.WriteLine(item);
            }
        }
    }
}
