//**PT: 2024-01-06 16:37
//**About:基本输入输出
//!服了你了连基础的框架和输入输出都不记得………………
// using System;
// namespace MainSpace//！这个你第一次写漏了……
// {
// 	class MainClass
// 	{
// 		static void Main()
// 		{
// 			var stringInputed = "";
// 			stringInputed= Console.ReadLine();//！艹注意是Console不是System啊！！！
// 			Console.Write("You inputed:\n" + stringInputed + "!", stringInputed);//！这里可以不用那个什么格式化字符串了……直接+！
// 			Main();//！未提供与“MainClass.Main(string[])”的所需参数“args”对应的参数 [D:\Code\C#_New\C#_New.csproj]
// 		}
// 		//！注意CS的调试是在“调试控制台的……别忘了……
// 		//！文件可以直接改名而不需要改配置文件
// 	}
// }
//**EOF 2024-01-06 16:53：千辛万苦第一个程序哈哈

//**PT 2024-01-06 18:50
//**About:关于格式化输入输出
// using System;
// namespace MainSpace
// {
// 	class FormatIO
// 	{
// 		// public string inputString;//！在退出构造函数时，不可为 null 的 字段“inputString”必须包含非 null 值。请考虑将 字段 声明为可以为 null。
// 		// public string inputString = new string;//！“string”不包含采用 0 个参数的构造函数
// 		string inputString = "";
// 		// inputString = Console.ReadLine();//!傻了这里都不是函数你搞个锤
// 		internal void input ()
// 		{
// 			inputString = Console.ReadLine();//！可能的null引用赋值az
// 		}
// 		internal void formatPrintMethod1()
// 		{
// 			// inputString = string.Format("")//！这个不是…………是用来格式化合并的
// 			Console.WriteLine("Type into the sentence");
// 			//！关键！记住它！
// 			string[] strings = inputString.Split(new char[3] { ' ', ',', ';' });//！这个方法不会删掉两个相邻的分隔…………
// 			Console.WriteLine("The words you input are list below");
// 			foreach (string s in strings)
// 				Console.WriteLine(s.Trim()); //！所以要加这个，咳咳没用，那部分本身就是一个空格了…………
// 		}
// 	}
// 	class MainClass
// 	{
// 		static void Main()//！不要漏了static啊！
// 		{
// 			FormatIO io = new FormatIO();
// 			io.input();
// 			io.formatPrintMethod1();
// 			Console.ReadLine();
// 			Main();
// 		}
// 	}
// }

//##################################################################################
//**PT 2024-01-08 10:39
//**About:关于指针的平替
// using System;

// using Microsoft.VisualBasic;

// namespace Pointer
// {
// 	class PointedClass
// 	{
// 		public int value = 0;
// 	}
// 	class MainClass
// 	{
// 		static void Main()
// 		{
// 			// object ClassPtr;
// 			//!并不是用object
// 			PointedClass ClassPtr;

// 			PointedClass pointedClass1 = new PointedClass() ;//！无法使用集合初始值设定项初始化类型“PointedClass”，原因是它不实现“System.Collections.IEnumerable”
// 			PointedClass pointedClass2 = new PointedClass();
// 			pointedClass1.value = 0;
// 			pointedClass2.value = 0;

// 			ClassPtr = pointedClass1;
// 			ClassPtr.value = 1;
// 			Console.WriteLine(pointedClass1.value);

// 			ClassPtr = pointedClass2;
// 			ClassPtr.value = 2;
// 			Console.WriteLine(pointedClass2.value);
// 			//！好耶证实了！类的 = 就是引用类型！
// 		}
// 	}
// }

//**PT 2024-01-08 12:40
//##About:关于list
//！太好用了吧哈哈哈
// using System;
// using System.Globalization;
// using System.Net.Http.Headers;
// using System.Security.Cryptography.X509Certificates;
// namespace ListTestSpace
// {
// 	class Thing
// 	{
// 		public string? content;
// 		public Thing(String? content)
// 		{
// 			this.content = content;//！自动补的，记得要用this！
// 		}
// 	}
// 	class MainClass
// 	{
// 		static void Main()
// 		{
// 			// List<int> nums = new List<int>();
// 			// Console.WriteLine("Type a series of numbers, use Enter to show the result");
// 			// while (true)
// 			// {
// 			// 	string? input = Console.ReadLine();
// 			// 	if (input == "") break;
// 			// 	// nums.Add((int)input);//！无法将string类型转换为int？？？
// 			// 	nums.Add(Convert.ToInt32(input));
// 			// }
// 			// foreach (var num in nums)
// 			// 	Console.WriteLine(num);

// 			//**----------------------------好耶！！好用！！！下面试一下类-----------------------------------------------------
// 			List<Thing> things = new List<Thing>();
// 			Console.WriteLine("Now enter some string");
// 			while (true)
// 			{
// 				string? input = Console.ReadLine();//！注意还是要再定义一次！上面那个好像也是作用域内的
// 				if (input == "") break;
// 				things.Add(new Thing(input));//！补出来的！！！会了！“Thing”不包含采用 1 个参数的构造函数所以只要加了这个就行
// 											 // things.Add();
// 			}
// 			foreach (Thing thing in things)
// 			{
// 				Console.WriteLine(thing.content);
// 			}
// 			//**----------------------------下标寻找-----------------------------------------------------
// 			Console.WriteLine("Type the orderNum to find the content.");
// 			while(true)
// 			{
// 				// int? input = Convert.ToInt32(Console.ReadLine());//！即使有下面这一行也会导致空输入错误………………
// 				// int? input = (var tmpintput = Console.ReadLine()) == ""?Console.WriteLine("Input is empty!"),break:Convert.ToInt32(tmpintput);//！即使有下面这一行也会导致空输入错误………………
// 				//!不行三目太局限了…………
// 				string? tmpIntput = Console.ReadLine();
// 				// if(tmpIntput == null)...
// 				if(tmpIntput == ""){ Console.WriteLine("Input is empty!"); continue; }//！注意是""而不是null！
// 				int input = Convert.ToInt32(tmpIntput);
// 				// if (input == null) break;//！哈哈可空类型
// 				if (input < 0 || input >= things.Count) Console.WriteLine("Please input a number between 0 and " + (things.Count - 1));
// 				else
// 				{
// 					Console.WriteLine(@"The "+ input.ToString() + "th content is " + things[input].content);//！果然可以这样！！但是要求必须要用int，short不行int?也不行
// 					// Console.WriteLine("Input is {input}");//！你以为为什么不能输出数字…………都没有tostring啊！而且在里面似乎不能这样搞要用+
// 				}
// 			}
// 		}
// 	}
// }
//**EOF 2024-01-08 13:32：OK基本实现！好玩！！！