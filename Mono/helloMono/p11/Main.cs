using System;

namespace p11
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		/*
		(11) (10)の表示機能をテストするため,0～19までの整数を収納する配列testAgesを新たに作成し
		foreachで次のように表示させてください
		0 (中略) 6 7 小学生 (中略) 12小学生 13中学生 14中学生 15中学生 16 (後略)
		*/
			int[] testAges = new int[20];
			for (int i =0; i < testAges.Length; i++) {
				testAges [i] = i;
			}
			foreach (var item in testAges) {
				var msg = item.ToString ();
				if ((item >= 7) && (item <= 12)) {
					msg += " 小学生";
				} else if ((item >= 13) && (item <= 15)) {
					msg += " 中学生";
				}
				Console.WriteLine (msg);
			}
		}
	}
}
