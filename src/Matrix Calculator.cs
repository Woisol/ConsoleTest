//**PT 2024-01-06 16:54
//**About:试图搞一个矩阵计算…………累死了只实现了简单输入输出
//**PT 2024-01-07 15:00+
//**About:实现了转置，搞控制命令还没搞好…………
//**EOF 2024-01-07 23:16：好晕啊…………我是谁？我现在搞到哪里了？
//**PT 2024-01-08 12:00+-
//**About:又忘记heading再写了…………
//！注意git会用好用但是不会用就会像刚刚15:05差点就新写的输入和list测试代码都丢了…………
//！原因似乎是在于在git desk那边切换了分支但是又没有commit现有的………………
//！还好有那个stashed好像恢复了………………
//td查一下那个stash听说很好用！
using System;
using System.ComponentModel.DataAnnotations;
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
		public int[,]? elements;
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
		//~~ internal void init()//！参数类型void无效…………
		//~~ {
		//~~ 	Console.Write("Input the length and height of the matrix(Format: m,n -> a m*n matrix): ");
		//~~ 	string? tmpInput = Console.ReadLine();//！加一个?就是可空类型了
		//~~ 	string[] parts = tmpInput.Split(',');
		//~~ 	length = short.Parse(parts[0].Trim()); //parts[0].Trim();//！无法将strng类型隐式转化为int
		//~~ 	height = Convert.ToInt16(parts[1].Trim());//！自动补全给出的解决方案
		//~~ 	//！详解：
		//~~ 	//!Trim()去掉前后空格
		//~~ 	//!Parse()将string类型转化为int类型，如果失败则返回0//艹这个注释是自己出来的
		//~~ 	//!而且这玩意居然是在int下而不是在string下
		//~~ 	//!Convert.ToInt16()将string类型转化为int类型，如果失败则返回0
		//~~ 	// length = Int16.Parse(Console.ReadLine());//！你看它这里自己补全的也是不用matrix.的………………
		//~~ 	// length = Convert.ToInt16(Console.ReadLine());//！你看它这里自己补全的也是不用matrix.的………………
		//~~ 	// height = Convert.ToInt16(Console.ReadLine());
		//~~ 	// Console.WriteLine()")//！笑死怎么又帮我写了哈哈不过不是想这样写
		//~~ }
		internal void input()
		{
			//**----------------------------传统思路，不过有二维list先搞搞看！！-----------------------------------------------------
			//~~ while(true)
			//~~ {
			//~~ 	string? input = Console.ReadLine();
			//~~ 	if(input == "\n"){}
			//~~ }
			//**----------------------------换个思路吧用传统思路好求多了…………！！！尝试用二维list！-----------------------------------------------------
			// var curLine = 0;

			//$处理第一行并获得列数
			string? tmpintput = Console.ReadLine();
			string[] lineElementString = tmpintput.Split(new char[2] {' ', ',' });
			length = (short)lineElementString.Length;
			int[] curLineElement = new int[length];
			for(var i = 0;i < length;i++)
				curLineElement[i] = Convert.ToInt32(lineElementString[i]);
			List<int[]> tmpElements = new List<int[]>();
			//！md服了！！！！！！！问通义它看不出来问NB才知道element少了一个s！！！！！！！！
			//！啊啊啊啊啊啊抽死你艹！！！
			tmpElements.Add(curLineElement);

			//$处理后面的行
			while (true)
			{
				// tmpElements.Add(curLineElement);//！艹这里还想补全少一个s给我…………原来有一个方法还是什么是elememt的
				//！不得移到上面还是两个一起改…………
				curLineElement = new int[length];
				//！是的NB说了，可以这样重置数组！！！
				tmpintput = Console.ReadLine();
				if (tmpintput == "") break;
				lineElementString = tmpintput.Split(new char[2] {' ', ',' });
				if((short)lineElementString.Length != length){Console.WriteLine("Elements length not consistent!Retype this line below!");continue; }
				for(var i = 0;i < length;i++)
					curLineElement[i] = Convert.ToInt32(lineElementString[i]);//！？？？这里居然会把一开始发一起改了？？？
																			  //！说明这个list可能更多是一个指针！还没有add之前修改是会修改的！
				// tmpElements.Add((int[])curLineElement.Clone());//td克隆的方法还要查一下
				tmpElements.Add(curLineElement);
			}

			//$放入数组中
			height = (short)tmpElements.Count;//！注意list的长度是用count！
			elements = new int[height, length];//!这里搞错了…………是先height在length啊！
			for (var i = 0; i < height; i++)
			for(var j = 0; j < length; j++)
				elements[i,j] = tmpElements[i][j];//！[] 内的索引数错误，应为 2，指的是要用[,]而不是[][]!

			//！极度混乱…………在于不知道有快捷的输入数字的方法…………
			//**----------------------------思路混乱，重写-----------------------------------------------------
			//~~ var line = 0;
			//~~ List<string> input = new List<string>();
			//~~ input.add(Console.ReadLine());
			//~~ string[] lineElementString = input[line++].Split(new char[2] { ' ', ',' });
			//~~ length = lineElementString.length;
			//~~ list<int> lineElement = new list<int>();//！不对啊这个也要用list啊！
			//~~ for(var i = 0;i < length;i++)
			//~~ lineElement[i] = convert.ToInt32(lineElementString[i]);
			//~~ while(true)
			//~~ {
			//~~ 	input.add(Console.ReadLine());
			//~~ 	lineElementString = input[line++].Split(new char[2] {'', ',' });
			//~~ 	if(length != input[line].length){console.WriteLine("Elements length not consistent!");line--; continue; }
			//~~ 	int[] lineElement = new int[length];
			//~~ 	for(var i = 0;i < length;i++)
			//~~ 	lineElement[i] = convert.ToInt32()
			//~~ }

			//**---------------------------------------------------------------------------------
			//！？？？这是什么语法？回头研究一下
			//~~ while (true)
			//~~ {
			//~~ 	try
			//~~ 	{
			//~~ 		length = Convert.ToInt16(Console.ReadLine());
			//~~ 		height = Convert.ToInt16(Console.ReadLine());
			//~~ 		break;
			//~~ 	}
			//~~ 	catch (Exception e)
			//~~ 	{
			//~~ 		Console.WriteLine("输入错误，请重新输入！");
			//~~ 	}
			//~~ }
		}
		internal void input(int length,int height)
		{
			elements = new int[length, height];//也是自己补全哈哈
			Console.WriteLine("Input the elements of the "+ length + "*" + height + " matrix: ");
			string? tmpInput = Console.ReadLine();
			string[] nums = tmpInput.Split(',');

			for(var i = 0;i < height;i ++)//!woq vsc在for里面都可以逐句调试我去…………
			for(var j = 0;j < length;j ++)
			{
				elements[i, j] = Convert.ToInt16(nums[i * height + j]);//!自动补全的锅…………是nums不是上面的parts啦
			}

			//~~ for (var i = 0; i < nums.Length; i++)
			//~~ {
			//~~ 	elements[i / height, i % height] = Convert.ToInt16(nums[i].Trim());
			//~~ }//！这个方法还不错？！
			//~~ for (var i = 0; i < elements.GetLength(0); i++)
			//~~ {
			//~~ 	for (var j = 0; j < elements.GetLength(1); j++)
			//~~ 	{
			//~~ 		Console.Write("Input the element of the element: ");
			//~~ 		elements[i, j] = Convert.ToInt16(Console.ReadLine());
			//~~ 	}
			//~~ }
			//！笑死这是要僭越了吧哈哈哈

		}
		internal void input(params int[] nums)
		//！可变长参数的方法！只需要一个params就行了！！
		//！注意只能由一个params只能标记一维数组而且后面不允许再有其它参数
		{
			if(nums.Length != length * height){ Console.WriteLine("Input error!"); return; }
						elements = new int[length, height];//！其实就是漏了这一句
			for (var i = 0; i < nums.Length; i++)
			{
				elements[i / height, i % height] = nums[i];//！这个方法也好用不难记！记它！
				//！Object reference not set to an instance of an object.
			}
			//！！！有没有可能！！！
			// foreach(var num in elements)
			// num = nums[i++];//！想得美，无法为“num”赋值，因为它是“foreach 迭代变量”
		}
		internal void print()
		{
			// string[][] matrixView = new string[length][height];//！无效的秩说明符: 应为“,”或“]”
			// string[][] matrixView = new string[length][];

			var i = 0;//！在foreach内static也对该项无效？？？
			var j = 0;
				//！隐式类型化的变量不能有多个声明符？？？
			foreach(var element in elements)
			{
				if(i++ == length){ j++; i = 1;Console.WriteLine(); };//！不能在if里面用？？？
				//!注意这里是i = 1！不然前面i++的就没用了
				// matrixView[j] = new string[height];//td算了本来想用上格式化输入放到matrixview里面再打印的算了累死了
				Console.Write(element + " ");//！又漏tostring但是一开始明明没有问题的呀
			}
			Console.WriteLine();
			//！用新方法被玩吐了………………
		}
		//**----------------------------Operation-----------------------------------------------------
		internal void Transpose()
		{
			//~~ int[,] tmpNum = new int[length, height];
			//~~ tmpNum.CopyTo(elements,0);//！艹极其方便哈哈哈问TY知道的。后面这个0是开始的下标
			//~~ for(var j = 0;j < height;j ++)
			//~~ for(var i = 0;i < length;i ++)
			//~~ {
			//~~ 		elements[i, j] = tmpNum[j, i];
			//~~ }
			//**----------------------------其实明显还有另一个不用那么多内存的而且可能更快的方法-----------------------------------------------------
			//~~ for (var j = 0; j < height; j++)
			//~~ // for(var i = 0, var tmp = 0;i < length;i ++)//！啊用了var不能再for里面定义多个变量？
			//~~ for(var i = j;i < length;i ++)//！记得这个写法啦！！经典也不难记！
			//~~ {
			//~~ 	elements[i,j] += elements[j, i];
			//~~ 	elements[j, i] = elements[i, j] - elements[j, i];
			//~~ 	elements[i, j] -= elements[j,i];
			//~~ 	//！这个方法会导致对角线上的元素变成0………………
			//~~ 	//！而且这玩意万一不是方阵就不对了………………
			//~~ }
			//**----------------------------方法不对，重写-----------------------------------------------------
			int[,] newMatrix = new int[height, length];
			for(var i = 0;i < length;i ++)
			for(var j = 0;j < height;j ++)
			{
				newMatrix[j, i] = elements[i, j];
			}
			elements = new int[height, length];
			// elements.CopyTo(newMatrix,0);//！高维数组不能用这种方法………………
			Array.Copy(newMatrix, elements, newMatrix.Length);
			//！！！高维数组可用这个！！！Array中的静态方法Copy！！！
		}
	}
	//！注意git也是分大小写的！如果弄错好像也能switch但是是switch到一个不知道的branch………………
	class CommandControl
	{
		//**----------------------------Matrix Operation-----------------------------------------------------
		//~~ static Matrix matrix1 = new Matrix();
		//~~ static Matrix matrix2 = new Matrix();
		//~~ static Matrix matrix3 = new Matrix();
		//~~ static Matrix matrix4 = new Matrix();
		//~~ static Matrix matrix5 = new Matrix();

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
			//~~ while(true)
			//~~ {
			//~~ 	Console.WriteLine("Input the command: ");
			//~~ 	string? input = Console.ReadLine();
			//~~ 	if(input == "exit") break;
			//~~ 	else if(input == "transpose") matrix.Transpose();
			//~~ 	else Console.WriteLine("Command error!");
			//~~ }//!md又是直接出来哈哈哈哈哈哈
			//~~ 			while(true)
			//~~ 			{
			//~~ 				Console.WriteLine(@"Matrix Calculator
			//~~ 1. Input the matrix
			//~~ 2. Transpose the matrix
			//~~ 3. Exit
			//~~ Input the command: ");//！记得逐字是@不是$………………
			//~~ 			}//!也是哈哈哈不过逐字是自己改的
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
			// Matrix matrix = new Matrix();//！az主要要用()
			// matrix.init(3,3);
			// matrix.input(1, 2, 3, 4, 5, 6, 7, 8, 9);
			// matrix.Transpose();
			// matrix.print();
			//**---------------------------------------------------------------------------------
			Matrix matrix = new Matrix();
			matrix.input();
			matrix.print();
			Main();

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
//**EOF 2024-01-06 21:31：累了，先这样吧，寒假在慢慢完善
//**EOF 2024-01-08 17:01：终于实现啦！！！！！！！类Matlab的矩阵输入！！！！！！！！！！
//**鬼知道搞了多久呜呜呜