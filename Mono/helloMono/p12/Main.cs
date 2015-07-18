using System;

namespace p12
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		/*
		(12) 入力された数値を読み取り,それを年齢と解釈して
		献血が可能な年齢か判別するプログラムを作成してください
		※献血が可能な年齢→16歳～69歳
		  献血が可能な年齢の場合→「献血できます」と表示
		  献血が不可能な年齢の場合→「献血できません」と表示
		*/
			while(true){
				string s = Console.ReadLine();
				if(s ==""){
					continue;
				}
				int inputInt = int.Parse (s);
				string msg = "献血できません";
				if ((inputInt >= 16) && (inputInt <= 69)) {
						msg = "献血できます";
					} 
				Console.WriteLine (msg);
			}
		}
	}
}
