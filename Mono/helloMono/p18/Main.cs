using System;

namespace p18
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		/*
		練習問題(18)while文を使って、「こんにちは」という文字列を
				　　5回表示するプログラムを作成してください。
		*/
			int i = 0;
			while(i < 5){
				Console.WriteLine ("こんにちは");
				i++;
			}
		}
	}
}
