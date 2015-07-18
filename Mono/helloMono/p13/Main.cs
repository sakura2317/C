using System;

namespace p13
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		/*
		(13)入力された数値を読み取り,それを年齢および身長として解釈し
		ジェットコースターに乗れるか判別するプログラムを作成してください
		条件…６歳以上でかつ身長１２０cm以上であること
			条件を満たした場合→「乗れます」と表示
			満たしていない場合→「乗れません」と表示

		※提示されていない仕様があったとしても,それなりに解釈して作ること
		*/
			while(true){
				Console.Write("年齢を入力してください：");
				string s = Console.ReadLine();
				if(s ==""){
					continue;
				}
				int age = int.Parse (s);
				Console.Write("身長を入力してください：");
				s = Console.ReadLine();
				if(s ==""){
					continue;
				}
				int height = int.Parse (s);

				Console.Write ("年齢：" + age + "身長：" + height);

				string msg = "乗れません";
				if(age >= 6 && height >=120){
					msg = "乗れます";
				}
				Console.WriteLine("..." + msg);
			}
		}
	}
}
