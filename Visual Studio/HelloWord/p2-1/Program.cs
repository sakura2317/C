using System;
using System.Collections;

namespace p2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable stocks = new Hashtable();
            stocks["やくそう"] = 50;
            stocks["どくけしそう"] = 20;
            stocks["せかいじゅのは"] = 1;
            stocks["せいすい"] = 3;

            foreach (var item in stocks.Keys)
            {
                Console.WriteLine(
                    "{0}\t{1,2}個",
                    item, stocks[item].ToString()
                );
            }
        }
    }
}
