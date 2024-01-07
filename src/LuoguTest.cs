//**PT 2024-01-06 21:33
//**About:1979.FindGcd
// using System;
// using System.Globalization;
// using Microsoft.VisualBasic;
// namespace FindGcd
// {
// 	class Solution
// 	{
// 		public int gcd(int a, int b)
// 		{
// 			if(b == 0)//运算符“!”无法应用于“int”类型的操作数！！！CS居然不行？！
// 			{
// 				return a;
// 				//!不行对gcd不熟悉…………
// 			}
// 			while (b != 0)
// 			{
// 				int temp = b;
// 				b = a % b;
// 				a = temp;
// 			}//！最快答案关键是是用到了这一点，补全出来了。
// 			return gcd(b, a % b);
// 		}
// 		public int FindGCD(int[] nums)
// 		{
// 			var min = nums[0];//！又犯这个毛病…………都是0了你后面还怎么有比它小的？
// 			var max = 0;
// 			foreach(var num in nums)
// 			{
// 				min = num < min? num : min;
// 				max = num > max? num : max;
// 			}

// 			//~~麻了int直接有大小的函数…………
// 			//!咳咳没事，这个只是int的最大值最小值而已
// 			//~~ var max = int.MaxValue;
// 			//~~ var min = int.MinValue;
			// return gcd(max, min);
// 		}

// 		static void Main(string[] args)
// 		{
// 			Solution solution = new Solution();
// 			string? input = Console.ReadLine();
// 			// int[] parts = Int32.Parse(input.Split(' '));//！没办法…………
// 			string[] parts = input.Split(' ');
// 			int[] nums = new int[parts.GetLength(0)];
// 			var i = 0;
// 			foreach (string stringPart in parts)
// 				// int[] nums = Convert.ToInt32(stringPart); //!…………还是有点麻烦…………
// 				nums[i ++] = Convert.ToInt32(stringPart);

// 			Console.WriteLine(solution.FindGCD(nums));
// 		}

// 	}
// }

//**PT 2024-01-06 22:14
//**About:1.Two Numbers' sum
//td
// using System;
// using System.Security;
// namespace Program
// {
// 	class Solution
// 	{
// 		static public int[] TwoSum(int[] nums, int target)
// 		{
// 			var i = 0; var j = 1;
// 			for (; i < nums.Length;i++)
// 			for(j = i + 1;j <nums.Length; j++)//！不写大括号了wi，：检测到无法访问的代码//额傻了没有必要
// 			if (nums[i] + nums[j] == target) return new int[] { i, j };//艹又是帮我写好了…………
// 			return new int[] {0,0};//！主要这个new int[]必须要的！
// 		}

// 		static void Main(string[] args)
// 		{
// 			string? input = Console.ReadLine();
// 			string[] parts = input.Split(' ');
// 			int[] nums = new int[parts.GetLength(0)];
// 			var i = 0;
// 			foreach(String part in parts)
// 			{
// 				nums[i] = Convert.ToInt32(part);
// 			}
// 			Console.WriteLine(TwoSum(nums, 9));//！对象引用对于非静态的字段、方法或属性“Solution.TwoSum(int[], int)”是必需的
// 			//！悟了没？其实就是让你实例化！！！不然就要用static！！！
// 			//!额输出不了………………累了拜拜
// 		}
// 	}
// }