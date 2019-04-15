using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WhereOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>() {1, 2, 3, 5, 6, 7, 8, 9};
            //string[] array = {"A", "B", "C", "D", "E"};
            var query = array.Where(x => x > 5);
            foreach (var number in query)
            {
                Console.WriteLine(number);
            }
        }
    }

    public static class LINQExtension
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source,
                                                  Predicate<T> selector)
        {
            foreach (var collection in source)
            {
                if (selector(collection))
                {
                    yield return collection;
                }
            }
        }
    }
}
