using System;

namespace p14
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		/*
		練習問題(14) 2つの値AとBをコンソール入力から読み取り,
		これらを比較して次のように表示するプログラムを作成してください
		AとBが等しい時→「(Aの値を出力)と(Bの値を出力)は等しい」
		AがBより大きい時→「(Aの値を出力)は(Bの値を出力)より大きい」
		AがBより小さい時→「(Aの値を出力)は(Bの値を出力)より小さい」

		例）6は10より小さい

		*/
			while(true){
				Console.Write("一つ目の数値を入力してください：");
				string s = Console.ReadLine();
				if(s ==""){
					continue;
				}
				double A = double.Parse (s);

				Console.Write("二つ目の数値を入力してください：");
				s = Console.ReadLine();
				if(s ==""){
					continue;
				}
				double B = double.Parse (s);
				
				Console.Write ("A：" + A + " B：" + B);
				
				
				string msg = "数値を入力してください";
				if(A == B){
					msg = A + "と" + B + "は等しい";
				}else if(A > B){
					msg = A + "は" + B + "より大きい";
				}else if(A < B){
					msg = A + "は" + B + "より小さい";
				}
				Console.WriteLine("..." + msg);
				
			}
		}
	}
}
