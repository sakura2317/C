using System;

namespace p1516
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		/*
		練習問題(15) 在庫の値をコンソール入力から読み取り
		在庫数に応じて次のように表示させるプログラムを作成してください
		在庫は整数値とします
			在庫が０の時→「在庫がありません」
			在庫が３個以下の時→「在庫がわずかです」
			それ以外の時→「在庫があります」
		練習問題(16) (15)のプログラムを,正の整数以外の数値や文字が入力された場合は
		再度の入力を促すように変更してください
		*/
			while(true){
				try {
					Console.Write("在庫数を入力してください：");
					string s = Console.ReadLine();
					if(s ==""){
						continue;
					}
					int stock = int.Parse (s);
					
					//Console.Write ("在庫数：" + stock);

					
					string msg = "在庫があります";
					if(stock < 0){
						msg = "正の整数を入力してください";
					}else if( stock == 0){
						msg = "在庫がありません";
					}else if(stock <= 3){
						msg = "在庫がわずかです";
					}
					Console.WriteLine(msg);
				}catch(Exception e){
					Console.WriteLine("正の整数を入力してください");
				}

				
			}
		}
	}
}
