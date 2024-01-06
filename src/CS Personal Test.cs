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

//**PT 2024-01-06 16:54
//**About:试图搞一个矩阵计算…………累死了
// using System;
// using System.Globalization;//!？？？怎么又出现了/汗是编译器需要加的吗？
// // using System.Diagnostics;
// // using System.Globalization;
// // using System.Xml.Schema;//!???哪里来的？

// //Test input:
// // 3,3
// // 1,2,3,4,5,6,7,8,9

// namespace MatrixCalculationApps
// {
// 	class Matrix
// 	{
// 		// private://！注意默认是private！
// 		//！注意这玩意是连自己的实例都不能访问的…………
// 		short length;
// 		short height;

// 		public int[,]? matrixNum;
// 		// internal://！类、记录、结构或接口成员声明中的标记“:”无效
// 		internal void init(short m,short n)//！都说了不要随便用其它类型…………你都习惯了int了
// 		{
// 			// matrix.length = m;//！对象引用对于非静态的字段、方法或属性“matrix.length”是必需的？？？
// 			length = m;//！正确方法是不用matrix.的！所以也注意变量命名！
// 			height = n;
// 			Console.WriteLine("Now initing a " + length + "*" + height + " matrix.");
// 			input();
// 		}
// 		internal void init()//！参数类型void无效…………
// 		{
// 			Console.Write("Input the length and height of the matrix(Format: m,n -> a m*n matrix): ");
// 			string? tmpInput = Console.ReadLine();//！加一个?就是可空类型了
// 			string[] parts = tmpInput.Split(',');
// 			length = short.Parse(parts[0].Trim()); //parts[0].Trim();//！无法将strng类型隐式转化为int
// 			height = Convert.ToInt16(parts[1].Trim());//！自动补全给出的解决方案
// 			//！详解：
// 			//!Trim()去掉前后空格
// 			//!Parse()将string类型转化为int类型，如果失败则返回0//艹这个注释是自己出来的
// 			//!而且这玩意居然是在int下而不是在string下
// 			//!Convert.ToInt16()将string类型转化为int类型，如果失败则返回0
// 			// length = Int16.Parse(Console.ReadLine());//！你看它这里自己补全的也是不用matrix.的………………
// 			// length = Convert.ToInt16(Console.ReadLine());//！你看它这里自己补全的也是不用matrix.的………………
// 			// height = Convert.ToInt16(Console.ReadLine());
// 			// Console.WriteLine()")//！笑死怎么又帮我写了哈哈不过不是想这样写

// 			input();
// 		}
// 		void input()
// 		{
// 			matrixNum = new int[length, height];//也是自己补全哈哈
// 			Console.WriteLine("Input the elements of the "+ length + "*" + height + " matrix: ");
// 			string? tmpInput = Console.ReadLine();
// 			string[] nums = tmpInput.Split(',');

// 			for(var i = 0;i < height;i ++)//!woq vsc在for里面都可以逐句调试我去…………
// 			for(var j = 0;j < length;j ++)
// 			{
// 				matrixNum[i, j] = Convert.ToInt16(nums[i * height + j]);//!自动补全的锅…………是nums不是上面的parts啦
// 			}

// 			// for (var i = 0; i < nums.Length; i++)
// 			// {
// 			// 	matrixNum[i / height, i % height] = Convert.ToInt16(nums[i].Trim());
// 			// }//！这个方法还不错？！
// 			// for (var i = 0; i < matrixNum.GetLength(0); i++)
// 			// {
// 			// 	for (var j = 0; j < matrixNum.GetLength(1); j++)
// 			// 	{
// 			// 		Console.Write("Input the element of the matrixNum: ");
// 			// 		matrixNum[i, j] = Convert.ToInt16(Console.ReadLine());
// 			// 	}
// 			// }
// 			//！笑死这是要僭越了吧哈哈哈

// 		}
// 		internal void print()
// 		{
// 			// string[][] matrixView = new string[length][height];//！无效的秩说明符: 应为“,”或“]”
// 			// string[][] matrixView = new string[length][];

// 			var i = 0;//！在foreach内static也对该项无效？？？
// 			var j = 0;
// 				//！隐式类型化的变量不能有多个声明符？？？
// 			foreach(var element in matrixNum)
// 			{
// 				if(i++ == length){ j++; i = 1;Console.WriteLine(); };//！不能在if里面用？？？
// 				//!注意这里是i = 1！不然前面i++的就没用了
// 				// matrixView[j] = new string[height];//td算了本来想用上格式化输入放到matrixview里面再打印的算了累死了
// 				Console.Write(element + " ");
// 			}
// 			//！用新方法被玩吐了………………
// 		}
// 	}
// 	class MainClass
// 	{
// 		static void Main()
// 		{
// 			Matrix matrix = new Matrix();//！az主要要用()
// 			matrix.init(3,3);
// 			matrix.print();

// 			// // int[3,2] matrix = { 1, 2, 3, 4, 5, 6 };//！注意不能直接这样声明…………不输入行列说应输入嵌入数组初始值设定值，输入了还是说要用new
// 			// int[,] matrix = new int[2,3]{ {1, 2, 3}, {4, 5, 6} };//！注意不能直接这样声明…………不输入行列说应输入嵌入数组初始值设定值，输入了还是说要用new
// 			// for(var i = 0;i< matrix.GetLength(0);i++)//！！！这个居然是它自己补全出来的！！！
// 			// {
// 			// 	for(var j = 0;j< matrix.GetLength(1);j++)
// 			// 	{
// 			// 		Console.Write(matrix[i,j] + " ");
// 			// 	}
// 			// 	Console.WriteLine();
// 			// }//！艹自动的哈哈
// 		}
// 	}
// }
// //**EOF 2024-01-06 21:31：累了，先这样吧，寒假在慢慢完善

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