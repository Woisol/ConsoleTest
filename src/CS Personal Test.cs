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
// 		public string inputString = "";
// 		// inputString = Console.ReadLine();//!傻了这里都不是函数你搞个锤
// 		void input ()
// 		{
// 			inputString = Console.ReadLine();//！可能的null引用赋值az
// 		}
// 		void formatPrintMethod1()
// 		{

// 		}
// 	}
// 	class MainClass
// 	{
// 		static void Main()//！不要漏了static啊！
// 		{

// 		}
// 	}
// }