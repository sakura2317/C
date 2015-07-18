using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> scores = new Dictionary<string, int>();
            scores["矢吹"] = 2;
            scores["丹下"] = 74;
            scores["力石"] = 80;
            scores["白木"] = 100;
            scores["西"] = 10;

            foreach (var key in scores.Keys) {
                Console.WriteLine("氏名：{0}\t点数：{1,3}", key, scores[key]);
            }

        }
    }
}
