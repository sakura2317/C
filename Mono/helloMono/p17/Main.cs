using System;

namespace p17
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		/*
		練習問題(17)テストの成績をコンソール入力から読み取り
		点数に応じて次のように表示させるプログラムを作成してください
		なお,正の整数以外の数値や文字が入力された場合は再度の入力を促すようにしてください。
			80点以上→「A判定」
			70点～79点→「B判定」
			60点～69点→「C判定」
			60点未満→「D判定」
		*/
			while(true){
				try {
					Console.Write("点数を入力してください：");
					string s = Console.ReadLine();
					int score = int.Parse (s);
					
					Console.Write ("点数：" + score);

					string msg = "点数を入力してください";
					if(score >=80){
						msg = "A判定";
					}else if(score >= 70 && score <= 79){
						msg = "B判定";
					}else if(score >= 60 && score <= 69){
						msg = "C判定";
					}else if(score <= 59){
						msg = "D判定";
					}
					Console.WriteLine("..." + msg);
					
				}catch{
					Console.WriteLine("正の整数を入力してください");
				}
				
			}
		}
	}
}
