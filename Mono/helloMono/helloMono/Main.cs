using System;

namespace helloMono
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Console.WriteLine ("Hello Shiraishi!");
//			Console.WriteLine ("Hello Kashino!");

//			string hw = "Hello World!";
//			Console.WriteLine (hw);

			//string myLastName = ("櫻畑");
			//string myFirstName = ("友里");
			//Console.WriteLine ("姓:" + myLastName);
			//Console.WriteLine ("名:" + myFirstName);

			//int[] myArray;
			//myArray = new int[4];
			//int[] myArray = new int[4]{0,1,2,3};
			//Console.WriteLine (myArray[2]);
			//myArray [2] = 99;
			//Console.WriteLine (myArray[2]);
			//練習問題(5)
			string[] lastNames = new string[4]{"Suzuki","Tanaka","Kimura","Shima"};
			string[] firstNames = new string[4]{"Taro","Hanako","Jiro","Tetsuo"};

			int j = 0;
			foreach(var item in lastNames){
				Console.WriteLine(item + " " + firstNames[j]);
				j++;
			}

			for (int i = 0; i < lastNames.Length; i++) {

			}

			/*
			int a = 1;
			if (a == 1) {
				Console.WriteLine ("a==1");
			} else if(a==2){
				Console.WriteLine("a==2");
			}else{
				Console.WriteLine("else");
			}
			*/
			/*
			int[] myArray2 = new int[]{10,11,12,13};
			for(int i = 0; i < myArray2.Length; i++){
				Console.WriteLine(i + ":" + myArray2[i]);
			}

			foreach(var item in myArray2){
				Console.WriteLine(item);
			}
			*/
		}
	}
}
