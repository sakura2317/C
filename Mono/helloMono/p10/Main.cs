using System;

namespace p10
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		/*
		(10) (8)の配列agesを使って次のように表示してください.
		7-12歳の場合：小学生
		13-15歳の場合：中学生
		18　11小学生　30　15中学生　55　32　10小学生
		*/
			int[] ages = new int[]{18,11,30,15,55,32,10};
			foreach (var item in ages) {
				var msg = item.ToString();
				if((item >= 7) && (item <= 12)){
					msg += " 小学生";
				}else if((item >= 13) && (item <= 15)){
					msg += " 中学生";
				}
				Console.WriteLine (msg);
			}
		}
	}
}
