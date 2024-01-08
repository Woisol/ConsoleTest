//**PT 2024-01-06 16:54
//**About:试图搞一个矩阵计算…………累死了只实现了简单输入输出
//**PT 2024-01-07 15:00+
//**About:实现了转置，搞控制命令还没搞好…………
//**EOF 2024-01-07 23:16：好晕啊…………我是谁？我现在搞到哪里了？
using System;
using System.Globalization;
using System.Reflection.Emit;
using MatrixCalculationApps;//!？？？怎么又出现了/汗是编译器需要加的吗？
// using System.Diagnostics;
// using System.Globalization;
// using System.Xml.Schema;//!???哪里来的？
//td用链表的形式搞矩阵储存………………

//~~Test input:
//~~ 3,3
//~~ 1,2,3,4,5,6,7,8,9

namespace MatrixCalculationApps
{
	class Matrix
	{
		//**----------------------------Characteristics-----------------------------------------------------
		// private://！注意默认是private！
		//！注意这玩意是连自己的实例都不能访问的…………
		internal string? name;
		short length;
		short height;
		public int[,]? element;
		static Matrix curMatrix;

		//**----------------------------DataIO-----------------------------------------------------
		// internal://！类、记录、结构或接口成员声明中的标记“:”无效
		public Matrix()
		//！构造函数！
		{
			Console.WriteLine("A new matrix has been created.");
		}
		internal void init(short m,short n)//！都说了不要随便用其它类型…………你都习惯了int了
		{
			// matrix.length = m;//！对象引用对于非静态的字段、方法或属性“matrix.length”是必需的？？？
			length = m;//！正确方法是不用matrix.的！所以也注意变量命名！
			height = n;

			// Console.WriteLine("Now initing a " + length + "*" + height + " matrix.");
			Console.WriteLine("Now initing a {length}*{height} matrix.");
		}
		// internal void init()//！参数类型void无效…………
		// {
		// 	Console.Write("Input the length and height of the matrix(Format: m,n -> a m*n matrix): ");
		// 	string? tmpInput = Console.ReadLine();//！加一个?就是可空类型了
		// 	string[] parts = tmpInput.Split(',');
		// 	length = short.Parse(parts[0].Trim()); //parts[0].Trim();//！无法将strng类型隐式转化为int
		// 	height = Convert.ToInt16(parts[1].Trim());//！自动补全给出的解决方案
		// 	//！详解：
		// 	//!Trim()去掉前后空格
		// 	//!Parse()将string类型转化为int类型，如果失败则返回0//艹这个注释是自己出来的
		// 	//!而且这玩意居然是在int下而不是在string下
		// 	//!Convert.ToInt16()将string类型转化为int类型，如果失败则返回0
		// 	// length = Int16.Parse(Console.ReadLine());//！你看它这里自己补全的也是不用matrix.的………………
		// 	// length = Convert.ToInt16(Console.ReadLine());//！你看它这里自己补全的也是不用matrix.的………………
		// 	// height = Convert.ToInt16(Console.ReadLine());
		// 	// Console.WriteLine()")//！笑死怎么又帮我写了哈哈不过不是想这样写

		// }
		internal void input()
		{
			var line = 0;

			list<string> input = new list<string>();
			input.add(console.ReadLine());
			string[] lineElementString = input[line++].Split(new char[2] { ' ', ',' });
			length = lineElementString.length;
			list<int> lineElement = new list<int>();//！不对啊这个也要用list啊！
			for(var i = 0;i < length;i++)
			lineElement[i] = convert.ToInt32(lineElementString[i]);
			while(true)
			{
				input.add(Console.ReadLine());
				lineElementString = input[line++].Split(new char[2] {'', ',' });
				if(length != input[line].length){console.WriteLine("Elements length not consistent!");line--; continue; }
				int[] lineElement = new int[length];
				for(var i = 0;i < length;i++)
				lineElement[i] = convert.ToInt32()
			}

			//**---------------------------------------------------------------------------------
			//！？？？这是什么语法？回头研究一下
			// while (true)
			// {
			// 	try
			// 	{
			// 		length = Convert.ToInt16(Console.ReadLine());
			// 		height = Convert.ToInt16(Console.ReadLine());
			// 		break;
			// 	}
			// 	catch (Exception e)
			// 	{
			// 		Console.WriteLine("输入错误，请重新输入！");
			// 	}
			// }
		}
		internal void input(int length,int height)
		{
			element = new int[length, height];//也是自己补全哈哈
			Console.WriteLine("Input the elements of the "+ length + "*" + height + " matrix: ");
			string? tmpInput = Console.ReadLine();
			string[] nums = tmpInput.Split(',');

			for(var i = 0;i < height;i ++)//!woq vsc在for里面都可以逐句调试我去…………
			for(var j = 0;j < length;j ++)
			{
				element[i, j] = Convert.ToInt16(nums[i * height + j]);//!自动补全的锅…………是nums不是上面的parts啦
			}

			// for (var i = 0; i < nums.Length; i++)
			// {
			// 	element[i / height, i % height] = Convert.ToInt16(nums[i].Trim());
			// }//！这个方法还不错？！
			// for (var i = 0; i < element.GetLength(0); i++)
			// {
			// 	for (var j = 0; j < element.GetLength(1); j++)
			// 	{
			// 		Console.Write("Input the element of the element: ");
			// 		element[i, j] = Convert.ToInt16(Console.ReadLine());
			// 	}
			// }
			//！笑死这是要僭越了吧哈哈哈

		}
		internal void input(params int[] nums)
		//！可变长参数的方法！只需要一个params就行了！！
		//！注意只能由一个params只能标记一维数组而且后面不允许再有其它参数
		{
			if(nums.Length != length * height){ Console.WriteLine("Input error!"); return; }
						element = new int[length, height];//！其实就是漏了这一句
			for (var i = 0; i < nums.Length; i++)
			{
				element[i / height, i % height] = nums[i];//！这个方法也好用不难记！记它！
				//！Object reference not set to an instance of an object.
			}
			//！！！有没有可能！！！
			// foreach(var num in element)
			// num = nums[i++];//！想得美，无法为“num”赋值，因为它是“foreach 迭代变量”
		}
		internal void print()
		{
			// string[][] matrixView = new string[length][height];//！无效的秩说明符: 应为“,”或“]”
			// string[][] matrixView = new string[length][];

			var i = 0;//！在foreach内static也对该项无效？？？
			var j = 0;
				//！隐式类型化的变量不能有多个声明符？？？
			foreach(var element in element)
			{
				if(i++ == length){ j++; i = 1;Console.WriteLine(); };//！不能在if里面用？？？
				//!注意这里是i = 1！不然前面i++的就没用了
				// matrixView[j] = new string[height];//td算了本来想用上格式化输入放到matrixview里面再打印的算了累死了
				Console.Write(element + " ");
			}
			//！用新方法被玩吐了………………
		}
		//**----------------------------Operation-----------------------------------------------------
		internal void Transpose()
		{
// 			int[,] tmpNum = new int[length, height];
			// tmpNum.CopyTo(element,0);//！艹极其方便哈哈哈问TY知道的。后面这个0是开始的下标
			// for(var j = 0;j < height;j ++)
			// for(var i = 0;i < length;i ++)
			// {
			// 		element[i, j] = tmpNum[j, i];
			// }
			//**----------------------------其实明显还有另一个不用那么多内存的而且可能更快的方法-----------------------------------------------------
			// for (var j = 0; j < height; j++)
			// // for(var i = 0, var tmp = 0;i < length;i ++)//！啊用了var不能再for里面定义多个变量？
			// for(var i = j;i < length;i ++)//！记得这个写法啦！！经典也不难记！
			// {
			// 	element[i,j] += element[j, i];
			// 	element[j, i] = element[i, j] - element[j, i];
			// 	element[i, j] -= element[j,i];
			// 	//！这个方法会导致对角线上的元素变成0………………
			// 	//！而且这玩意万一不是方阵就不对了………………
			// }
			//**----------------------------方法不对，重写-----------------------------------------------------
			int[,] newMatrix = new int[height, length];
			for(var i = 0;i < length;i ++)
			for(var j = 0;j < height;j ++)
			{
				newMatrix[j, i] = element[i, j];
			}
			element = new int[height, length];
			// element.CopyTo(newMatrix,0);//！高维数组不能用这种方法………………
			Array.Copy(newMatrix, element, newMatrix.Length);
			//！！！高维数组可用这个！！！Array中的静态方法Copy！！！
		}
	}
	//！注意git也是分大小写的！如果弄错好像也能switch但是是switch到一个不知道的branch………………
	class CommandControl
	{
		//**----------------------------Matrix Operation-----------------------------------------------------
		// static Matrix matrix1 = new Matrix();
		// static Matrix matrix2 = new Matrix();
		// static Matrix matrix3 = new Matrix();
		// static Matrix matrix4 = new Matrix();
		// static Matrix matrix5 = new Matrix();

		static List<Matrix> matrixs = new List<Matrix>();


		static Matrix? curMatrix1;
		static Matrix? curMatrix2;
		Matrix? searchMatrix(string name)
		{
			foreach(var matrix in matrixs)
			{
				if (matrix.name == name) return matrix;//！注意不是this！这里this指的是CommandControl！
			}
			return null;
		}

		//**----------------------------IO-----------------------------------------------------
		void input()
		{
			// while(true)
			// {
			// 	Console.WriteLine("Input the command: ");
			// 	string? input = Console.ReadLine();
			// 	if(input == "exit") break;
			// 	else if(input == "transpose") matrix.Transpose();
			// 	else Console.WriteLine("Command error!");
			// }//!md又是直接出来哈哈哈哈哈哈
			// 			while(true)
			// 			{
			// 				Console.WriteLine(@"Matrix Calculator
			// 1. Input the matrix
			// 2. Transpose the matrix
			// 3. Exit
			// Input the command: ");//！记得逐字是@不是$………………
			// 			}//!也是哈哈哈不过逐字是自己改的
			Console.WriteLine(@"Matrix Calculator
Type ""help"" for Command Support.
Enjoy it;)");
			while (true)
			{
				String? input = Console.ReadLine();
// 				switch (input)
// 				{
// 					case "help":
// 						Console.WriteLine(@"1. Use ""[Matrix Name] = \{Elements\}"" to initialize the matrix.
// 2. Use ""[matrix]'"" to activate action Transpose.
// 3. Use ""exit"" to exit.");//！艹忘记了输出“是用两个”“而不是\！
// 						break;
// 					// case { string matrixName, '=',params int[] num }://！似乎不太行的样子…………
// 					case {input.Contains("=")}:
// 				}
				//**----------------------------不行switch无法满足需求，还是得用if？-----------------------------------------------------
				//！浅看了一下，C#的switch还是很强大的！看看！https://www.cnblogs.com/mq0036/p/16941611.html
				// if(input.ToLower().CompareTo("help"))//！这样叠加是错误的，逻辑问题，compareto不是这么用的
				if(input.ToLower() =="help")//！可以直接比较！！！
					Console.WriteLine(@"1. Use ""[Matrix Name] = \{Elements\}"" to initialize the matrix.
2. Use ""[matrix]'"" to activate action Transpose.
3. Use ""exit"" to exit.");//！艹忘记了输出“是用两个”“而不是\！
				else if(input.ToLower() =="exit"){ return; }
				else if(input.Contains("="))
				{
					string[] parts = input.Split('=');
					if(parts.Length != 2) error();

				}
				// else
				// {
				// 	input.
				// }
			}
		}
		static void error()
		{
			Console.WriteLine("Error!");
		}
	}

	// class MatrixPointer
	// {
	// 	// internal Matrix* matrix;//指针和固定大小缓冲区只能在不安全的上下文中使用
	// 	internal short curPos;

	// }
	//!晕死好像不太能指，先不学了累死
	class MatrixCalculationApps
	{
		// static internal int matrixNum = 0;
		static void Main()
		{
			//**----------------------------Testing Code-----------------------------------------------------
			Matrix matrix = new Matrix();//！az主要要用()
			matrix.init(3,3);
			matrix.input(1, 2, 3, 4, 5, 6, 7, 8, 9);
			matrix.Transpose();
			matrix.print();
			//**---------------------------------------------------------------------------------


				// // int[3,2] matrix = { 1, 2, 3, 4, 5, 6 };//！注意不能直接这样声明…………不输入行列说应输入嵌入数组初始值设定值，输入了还是说要用new
				// int[,] matrix = new int[2,3]{ {1, 2, 3}, {4, 5, 6} };//！注意不能直接这样声明…………不输入行列说应输入嵌入数组初始值设定值，输入了还是说要用new
				// for(var i = 0;i< matrix.GetLength(0);i++)//！！！这个居然是它自己补全出来的！！！
				// {
				// 	for(var j = 0;j< matrix.GetLength(1);j++)
				// 	{
				// 		Console.Write(matrix[i,j] + " ");
				// 	}
				// 	Console.WriteLine();
				// }//！艹自动的哈哈
		}
	}
}
// //**EOF 2024-01-06 21:31：累了，先这样吧，寒假在慢慢完善
