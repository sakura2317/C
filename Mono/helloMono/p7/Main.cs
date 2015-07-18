using System;

namespace p7
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		/*
		練習問題(7)　次の部屋の面積を坪単位に換算して、小数第2位まで画面に表示してください
		なお、1坪は3.3平方メートルです
		101号室　100平方メートル(30.30坪)
		102号室　 75平方メートル(22.73坪)
		103号室　150平方メートル(45.45坪)
		*/
			double[] areas = new double[]{100,75,150};
			double oneTsubo = 3.3d;
			string[] rooms = new string[]{"101","102","103"};

			for(int i = 0;i< rooms.Length; i++){
				Console.WriteLine ("{0}号室 {1,3}平方メートル({2,5}坪)",rooms[i],areas[i],
				                   (areas[i] / oneTsubo).ToString("F2"));
			}
		}
	}
}
