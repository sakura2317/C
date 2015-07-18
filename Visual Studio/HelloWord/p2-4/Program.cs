﻿using System;
using System.Collections;

namespace p2_4
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
            int total = 0;

            foreach (var key in scores.Keys){
                var name = key;
                if (key.Length == 1){
                    name = " " + key;
                }
                Console.WriteLine("氏名：{0}\t点数：{1,3}", name, scores[key]);
                total += scores[key];
            }

            Console.WriteLine("受験者\t{0,3}名",scores.Count);
            Console.WriteLine("合計点\t{0,3}点",total);
            Console.WriteLine("平均点\t{0,3}点",total/ scores.Count);
        }
    }
}
