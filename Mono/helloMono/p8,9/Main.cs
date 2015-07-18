using System;

namespace p89
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		/*
		練習問題(8) 整数の配列 ages を作成し,年齢を表す次のデータを収納してください
		18　11　30　15　55　32　10
		練習問題(9) (8)の配列agesを使って年齢が20歳以上のとき
		「成人」と表示してください
		18　11　30 成人　15　55成人　32成人　10
		*/
			int[] ages = new int[]{18,11,30,15,55,32,10};
			foreach (var item in ages) {
				var msg = item.ToString();
				if (item >= 20) {
					msg += " 成人";
				}
				Console.WriteLine (msg);
			}
		}
	}
}
