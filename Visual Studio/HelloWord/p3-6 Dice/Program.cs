using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var dice = new Dice[3];

            while (true)
            {
                string input = Console.ReadLine();
                string msg = "";
                if (input == "h")
                {
                    for ()
                    {
                        msg = dice[i].getHistory();
                        msg += dice[i].getStats();
                    }
                else
                {
                    int result = dice.Roll();
                    msg = result.ToString();

                }
                Console.WriteLine(msg);
            }
        }
    }
}
