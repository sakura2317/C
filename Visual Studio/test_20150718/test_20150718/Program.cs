using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_20150718
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> n = new List<double>() { 1.1, 2.2 };
                Console.WriteLine("合計：" + n.Sum() + "最小：" + n.Min());
        }
    }
}
