using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_6
{
    class Dice
    {
        private int[] stats;
        private List<int> history;
        private int total;

        Random r = new Random();


        public Dice()
        {
            stats = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
            history = new List<int>();
        }

        public int Roll()
        {
            //サイコロをふる
            int result = r.Next(1,7);
            //履歴に保存
            history.Add(result);
            //統計配列に保存
            stats[result]++;
            //結果を返す
            return result;
        }

        //統計情報を出す
        public string getStats()
        {
            int sum = 0;
            for (int i = 1; i <= 6; i++)
            {
                int ratio = stats[i] * 100 / total;
                msg += i + ":" + stats[i] + "(" + "%)\n";
                sum += stats[i] * i;
            }
            msg += "合計：" + total + "回\n";
            msg += "平均：" + ((double)sum / total) + "\n";

            return "";
        }
        //履歴情報を出す
        public string getHistory()
        {
            foreach (var item in history)
            {
                msg += "" + item;
            }
            msg += "\n";
        }

        history.Add(result);
            stats[result]++;
            total++;

            return "";
        }
    }
}
